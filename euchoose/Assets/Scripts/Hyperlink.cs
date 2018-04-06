using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{
    public void SendToLink()
    {
        switch (SceneHandler.nrq)
        {
            case 1:
                {
                    Application.OpenURL("http://www.europarl.europa.eu/sides/getDoc.do?pubRef=-//EP//TEXT+TA+P8-TA-2014-0060+0+DOC+XML+V0//EN");
                    break;
                }
            case 2:
                {
                    Application.OpenURL("https://epthinktank.eu/2017/02/13/combating-terrorism-eu-legislation-in-progress/");
                    break;
                }
            case 3:
                {
                    Application.OpenURL("http://www.europarl.europa.eu/oeil-mobile/fiche-procedure/2017/0007(COD)");
                    break;
                }
            case 4:
                {
                    Application.OpenURL("http://www.europarl.europa.eu/RegData/etudes/BRIE/2016/579110/EPRS_BRI(2016)579110_EN.pdf");
                    break;
                }
            case 5:
                {
                    Application.OpenURL("http://www.europarl.europa.eu/sides/getDoc.do?pubRef=-//EP//TEXT+TA+P8-TA-2016-0358+0+DOC+XML+V0//EN");
                    break;
                }
			case 6:
				{
					Application.OpenURL ("http://www.europarl.europa.eu/sides/getDoc.do?pubRef=-//EP//TEXT+TA+P8-TA-2016-0511+0+DOC+XML+V0//EN");
					break;
				}
            case 7:
                {
                    Application.OpenURL("http://www.europarl.europa.eu/sides/getDoc.do?pubRef=-//EP//TEXT+TA+P8-TA-2017-0018+0+DOC+XML+V0//EN");
                    break;
                }
            case 8:
                {
                    Application.OpenURL("http://www.europarl.europa.eu/news/en/news-room/20170131IPR60306/georgia-visa-waiver-approved-by-parliament");
                    break;
                }
            case 9:
                {
                    Application.OpenURL("http://ec.europa.eu/trade/policy/in-focus/ceta/ceta-explained/");
                    break;
                }
		
			case 10:
                {
                    Application.OpenURL("https://ec.europa.eu/commission/news/european-parliament-approves-wholesale-roaming-prices_en");
                    break;
                }
			case 11:
				{
					Application.OpenURL("http://ec.europa.eu/trade/policy/in-focus/ceta/ceta-explained/");
					break;
				}
			case 12:
				{
					Application.OpenURL("http://ec.europa.eu/trade/policy/in-focus/ceta/ceta-explained/");
					break;
				}
			case 13:
				{
					Application.OpenURL("http://ec.europa.eu/trade/policy/in-focus/ceta/ceta-explained/");
					break;
				}
			case 14:
				{
					Application.OpenURL("http://ec.europa.eu/trade/policy/in-focus/ceta/ceta-explained/");
					break;
				}
			default:
				{
					Application.OpenURL("http://ec.europa.eu/trade/policy/in-focus/ceta/ceta-explained/");
					break;
				}
		}
    }
}
