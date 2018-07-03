using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace TWImageChecker
{
    class FindAssets
    {

        
        List<string> FilesToFind = new List<string>();
        List<string> missingAssets = new List<string>();

        string addtoFileName = "bathroom_standard_";

        string tempfile;
        string _ = "_";





        public void searchMainFiles(string assetLocation)
        {
            FilesToFind.Clear();

            DirectoryInfo dirAssetLocation = new DirectoryInfo(assetLocation);

            FileInfo[] allFiles = dirAssetLocation.GetFiles("*", SearchOption.AllDirectories);

            foreach (string TowelRail in HoldCodes.TowelRailProductCodes)
            {
                foreach (string WallTile in HoldCodes.WallTileProductCodes)
                {
                    foreach (string BasinTap in HoldCodes.BasinTapProductCodes)
                    {
                        foreach (string TileTrim in HoldCodes.TileTrimProductCodes)
                        {
                            foreach (string Package in HoldCodes.PackageProductCodes)
                            {
                                foreach (string TileArea in HoldCodes.TileAreaCodes)
                                {
                                    tempfile = addtoFileName +
                                    HoldCodes.TowelRailPartCode + _ + TowelRail + _ +
                                    HoldCodes.WallTilePartCode + _ + WallTile + _ +
                                    HoldCodes.BasinTapPartCode + _ + BasinTap + _ +
                                    HoldCodes.TileTrimPartCode + _ + TileTrim + _ +
                                    HoldCodes.PackagePartCode + _ + Package + _ + TileArea + ".jpg";

                                    FilesToFind.Add(tempfile);

                                }
                            }
                        }

                    }
                }
            }

            if (allFiles.Length > 0)
            {
                foreach (FileInfo f in allFiles)
                {
                    if (FilesToFind.Contains(f.Name))
                    {
                        FilesToFind.Remove(f.Name);
                    }
                }

                foreach (string ff in FilesToFind)
                {
                    missingAssets.Add(ff);
                }

            }
            else if (allFiles.Length == 0)
            {
                foreach (string f in FilesToFind)
                {
                    missingAssets.Add(f);
                }

            }


        }

        public void searchFlooringFiles(string assetLocation)
        {
            FilesToFind.Clear();

            DirectoryInfo dirAssetLocation = new DirectoryInfo(assetLocation);

            FileInfo[] allFiles = dirAssetLocation.GetFiles("*", SearchOption.AllDirectories);

            foreach (string Flooring in HoldCodes.FlooringProductCodes)
            {
                            foreach (string Package in HoldCodes.PackageProductCodes)
                            {

                                    tempfile = addtoFileName +
                                    HoldCodes.FlooringPartCode + _ + Flooring + _ +
                                    HoldCodes.PackagePartCode + _ + Package + ".png";

                                    FilesToFind.Add(tempfile);

                                }
   }


            if (allFiles.Length > 0)
            {
                foreach (FileInfo f in allFiles)
                {
                    if (FilesToFind.Contains(f.Name))
                    {
                        FilesToFind.Remove(f.Name);
                    }
                }

                foreach (string ff in FilesToFind)
                {
                    missingAssets.Add(ff);
                }

            }
            else if (allFiles.Length == 0)
            {
                foreach (string f in FilesToFind)
                {
                    missingAssets.Add(f);
                }

            }
        }

        public void searchBathFiles(string assetLocation)
        {
            FilesToFind.Clear();

            DirectoryInfo dirAssetLocation = new DirectoryInfo(assetLocation);

            FileInfo[] allFiles = dirAssetLocation.GetFiles("*", SearchOption.AllDirectories);

            foreach (string WallTiles in HoldCodes.WallTileProductCodes)
            {
                foreach (string BathTaps in HoldCodes.BathTapProductCodes)
                {

                    foreach (string Bath in HoldCodes.BathProductCodes)
                    {

                        tempfile = addtoFileName +
                        HoldCodes.WallTilePartCode + _ + WallTiles + _ +
                         HoldCodes.BathTapPartCode + _ + BathTaps + _ +
                        HoldCodes.BathPartCode + _ + Bath + ".png";

                        FilesToFind.Add(tempfile);

                    }
                }
            }


            if (allFiles.Length > 0)
            {
                foreach (FileInfo f in allFiles)
                {
                    if (FilesToFind.Contains(f.Name))
                    {
                        FilesToFind.Remove(f.Name);
                    }
                }

                foreach (string ff in FilesToFind)
                {
                    missingAssets.Add(ff);
                }
                
            }
            else if (allFiles.Length == 0)
            {
                foreach (string f in FilesToFind)
                {
                    missingAssets.Add(f);
                }

            }
        }

            public void searchAllFiles(string assetLocation)
        {
            searchMainFiles(assetLocation);
            searchFlooringFiles(assetLocation);
            searchBathFiles(assetLocation);

        }

        public void createMissingAssetsTextFile(string saveLocation)
        {
            try 
            {

             saveLocation = saveLocation + "\\" + "MissingTWAssets.txt";

             File.WriteAllLines(saveLocation, missingAssets);
                MessageBox.Show("Error List Created", "Error List Created", MessageBoxButtons.OK);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
            }
        }






    }
}
