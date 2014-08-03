using System;
using System.Collections.Generic;
using System.Text;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace AssisticantMobile.ViewModels
{
    public class TileViewModel
    {
        private void UpdateLiveTile()
        {
            var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text01);

            var tileImage = tileXml.GetElementsByTagName("image")[0] as XmlElement;
            tileImage.SetAttribute("src", "ms-appx:///Assets/bild.JPG");

            var tileText = tileXml.GetElementsByTagName("text");
            (tileText[0] as XmlElement).InnerText = "Row 0";
            (tileText[1] as XmlElement).InnerText = "Row 1";
            (tileText[2] as XmlElement).InnerText = "Row 2";
            (tileText[3] as XmlElement).InnerText = "Row 3";

            var tileNotification = new TileNotification(tileXml);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
        }
    }
}
