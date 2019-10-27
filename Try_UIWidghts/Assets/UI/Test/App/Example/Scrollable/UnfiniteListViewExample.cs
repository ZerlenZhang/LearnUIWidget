using System;
using System.Collections.Generic;
using System.Linq;
using UI.Test.Utility;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.scheduler;
using Unity.UIWidgets.widgets;

namespace UI.Test.App.Scrollable
{
    public class UnfiniteListViewExample : UIWidgetsPanel
    {
        protected override Widget createWidget()
        {
            return new UnfiniteListViewWidget().GetScaffold().GetMaterialApp();
        }
    }

    public class UnfiniteListViewWidget : StatefulWidget
    {
        public override State createState()
        {
            return new UnfiniteListViewState();
        }
    }

    public class UnfiniteListViewState : State<UnfiniteListViewWidget>
    {
        private const string LoadingText = "我可是有底线的";
        private const string title = "昌平店铺";
        private const int allInfoCount = 100;

        private List<string> mWords = new List<string>
        {
            LoadingText
        };

        private Divider _divider = new Divider(color: Colors.black12);

        private void RetrieveData()
        {
            TickerFutureImpl.Delayed(TimeSpan.FromSeconds(2))
                .Then(() =>
                {
                    mWords.InsertRange(mWords.Count - 1,
                        Enumerable.Range(mWords.Count - 1, mWords.Count - 1 + 20).Select(i => "Hello " + i)
                    );
                    setState();
                });
        }


        public override Widget build(BuildContext context)
        {
            return Q.Flex
                    .Direction(Axis.vertical)
                    .Child(Q.Container
                        .Alignment(Alignment.center)
                        .Child(Q.Text
                            .Data(title)
                            .Size(50)
                            .End())
                        .End()
                        .GetExpanded(1))
                    .Child(ListView.seperated(
                        itemCount: mWords.Count,
                        itemBuilder: (buildContext, index) =>
                        {
                            //如果到了表尾
                            if (mWords[index] == LoadingText)
                            {
                                //不足100条，加载数据
                                if (mWords.Count - 1 < allInfoCount)
                                {
                                    RetrieveData();
                                    return Q.Container
                                        .Padding(EdgeInsets.all(16))
                                        .Alignment(Alignment.center)
                                        .Child(new CircularProgressIndicator(strokeWidth: 2.0f).GetSizeBox(24, 24))
                                        .End();
                                }

                                return Q.Container
                                    .Alignment(Alignment.center)
                                    .Padding(EdgeInsets.all(16))
                                    .Child(Q.Text
                                        .Data(LoadingText)
                                        .Color(Colors.grey)
                                        .End())
                                    .End();
                            }

                            return new ListTile(title: Q.Container
                                .Alignment(Alignment.center)
                                .Child(
                                    Q.Text.Data(mWords[index]).End())
                                .End());
                        },
                        separatorBuilder: (buildContext, index) => _divider)
                        .GetExpanded(5))
                    .End();
        }
    }
}