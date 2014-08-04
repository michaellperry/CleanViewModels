using Assisticant;
using Assisticant.Fields;
using AssisticantMobile.Models;
using System;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using AssisticantMobile;

namespace AssisticantMobile.ViewModels
{
    public class TileUpdater
    {
        private readonly ArticleSelection _selection;

        private Computed<TileDescription> _liveTile;

        public TileUpdater(ArticleSelection selection)
        {
            _selection = selection;

            _liveTile = new Computed<TileDescription>(
                () => ComputeTileDescription());
            _liveTile.Subscribe(t => UpdateLiveTile(t));
        }

        private TileDescription ComputeTileDescription()
        {
            var article = _selection.SelectedArticle;
            if (article != null)
            {
                return new TileDescription
                {
                    Line1 = article.Title,
                    Line2 = article.Author,
                    Line3 = String.Format("{0:d}", article.Date)
                };
            }

            return null;
        }

        private static void UpdateLiveTile(TileDescription tileDescription)
        {
            if (tileDescription != null)
            {
                var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text01);

                var tileText = tileXml.GetElementsByTagName("text");
                (tileText[0] as XmlElement).InnerText = tileDescription.Line1;
                (tileText[1] as XmlElement).InnerText = tileDescription.Line2;
                (tileText[2] as XmlElement).InnerText = tileDescription.Line3;

                var tileNotification = new TileNotification(tileXml);
                TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
            }
        }
    }
}
