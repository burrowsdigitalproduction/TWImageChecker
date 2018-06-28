using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TWImageChecker
{
    public class GetCodes
    {
        public string TowelRailPartCode;
        public List<string> TowelRailProductCodes = new List<string>();


        public string WallTilePartCode;
        public List<string> WallTileProductCodes = new List<string>();

        public string BathTapPartCode;
        public List<string> BathTapProductCodes = new List<string>();

        public string BasinTapPartCode;
        public List<string> BasinTapProductCodes = new List<string>();

        public string TileTrimPartCode;
        public List<string> TileTrimProductCodes = new List<string>();

        public string PackagePartCode;
        public List<string> PackageProductCodes = new List<string>();

        public string FlooringPartCode;
        public List<string> FlooringProductCodes = new List<string>();

        public string BathPartCode;
        public List<string> BathProductCodes = new List<string>();

        public List<string> TileAreaCodes = new List<string>();


        public void getAllCodes()
        {



            string jsonFile = File.ReadAllText(@"\\bcluster\burrows\digital\autorender\taylorwimpey\Production\Tool\TWData.json");
            var DataList = JsonConvert.DeserializeObject<GetCodes>(jsonFile);

            TowelRailPartCode = DataList.TowelRailPartCode;
            WallTilePartCode = DataList.WallTilePartCode;
            BasinTapPartCode = DataList.BasinTapPartCode;
            TileTrimPartCode = DataList.TileTrimPartCode;
            PackagePartCode = DataList.PackagePartCode;
            FlooringPartCode = DataList.FlooringPartCode;

            BathTapPartCode = DataList.BathTapPartCode;
            BathPartCode = DataList.BathPartCode;


            TowelRailProductCodes.Add("");
            FlooringProductCodes.Add("");

            foreach (string twprodcode in DataList.TowelRailProductCodes)
            {
                TowelRailProductCodes.Add(twprodcode);
            }

            foreach (string wtprodcode in DataList.WallTileProductCodes)
            {
                WallTileProductCodes.Add(wtprodcode);
            }

            foreach (string bthtprodcode in DataList.BathTapProductCodes)
            {
                BathTapProductCodes.Add(bthtprodcode);
            }

            foreach (string bsntprodcode in DataList.BasinTapProductCodes)
            {
                BasinTapProductCodes.Add(bsntprodcode);
            }

            foreach (string ttprodcode in DataList.TileTrimProductCodes)
            {
                TileTrimProductCodes.Add(ttprodcode);
            }

            foreach (string pkgprodcode in DataList.PackageProductCodes)
            {
                PackageProductCodes.Add(pkgprodcode);
            }

            foreach (string flrprodcode in DataList.FlooringProductCodes)
            {
                FlooringProductCodes.Add(flrprodcode);
            }

            foreach (string bthprodcode in DataList.BathProductCodes)
            {
                BathProductCodes.Add(bthprodcode);
            }

            foreach (string tileAreacode in DataList.TileAreaCodes)
            {
                TileAreaCodes.Add(tileAreacode);
            }

            HoldCodes.TowelRailPartCode = TowelRailPartCode;
            HoldCodes.TowelRailProductCodes = TowelRailProductCodes;

            HoldCodes.WallTilePartCode = WallTilePartCode;
            HoldCodes.WallTileProductCodes = WallTileProductCodes;

            HoldCodes.BathTapPartCode = BathTapPartCode;
            HoldCodes.BathTapProductCodes = BathTapProductCodes;

            HoldCodes.BasinTapPartCode = BasinTapPartCode;
            HoldCodes.BasinTapProductCodes = BasinTapProductCodes;

            HoldCodes.TileTrimPartCode = TileTrimPartCode;
            HoldCodes.TileTrimProductCodes = TileTrimProductCodes;

            HoldCodes.PackagePartCode = PackagePartCode;
            HoldCodes.PackageProductCodes = PackageProductCodes;

            HoldCodes.FlooringPartCode = FlooringPartCode;
            HoldCodes.FlooringProductCodes = FlooringProductCodes;

            HoldCodes.BathPartCode = BathPartCode;
            HoldCodes.BathProductCodes = BathProductCodes;

            HoldCodes.TileAreaCodes = TileAreaCodes;


        }

    }
}
