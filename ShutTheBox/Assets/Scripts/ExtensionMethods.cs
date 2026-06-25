using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts
{
    public static class ExtensionMethods
    {
        public static IList<Tile> GetValidTiles(Box box, int sum)
        {
            var boxTiles = box.tiles.Where(t => !t.IsClosed).ToList();
            var validTiles = boxTiles.Where(t => t.Value == sum).ToList();

            switch (sum)
            {
                case 2:
                    // Do Nothing
                    break;

                case 3:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2));
                    }
                    break;

                case 4:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3));
                    }
                    break;

                case 5:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3));
                    }
                    break;

                case 6:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3));
                    }
                    break;

                case 7:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4));
                    }
                    break;

                case 8:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4));
                    }
                    break;

                case 9:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 4));
                    }
                    break;

                case 10:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 5));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 4));
                    }
                    break;

                case 11:
                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 5));
                    }
                    break;

                case 12:
                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 5));
                    }
                    break;

                case 13:
                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4 || t.Value == 5));
                    }
                    break;

                case 14:
                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 5));
                    }
                    break;

                case 15:
                    if (boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 5 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 6 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 7 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 5));
                    }
                    break;

                case 16:
                    if (boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 6 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 7 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 5 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 6 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 7 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 6));
                    }
                    break;

                case 17:
                    if (boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 7 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 8) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 8 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 6 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 7 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 5 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 6 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 7 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 5 || t.Value == 6));
                    }
                    break;

                case 18:
                    if (boxTiles.Any(t => t.Value == 8) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 8 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 7 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 8) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 8 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 6 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 7 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 5 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 6 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 7 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 4 || t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 5 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 5 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 6 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 7) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 7 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 10))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 4 || t.Value == 10));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 5 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 3 || t.Value == 6 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 4 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 9))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 9));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 5 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 6) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 3 || t.Value == 6 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 2 || t.Value == 4 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 3 || t.Value == 4 || t.Value == 5 || t.Value == 6));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 8))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 4 || t.Value == 8));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 3) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 7))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 3 || t.Value == 5 || t.Value == 7));
                    }

                    if (boxTiles.Any(t => t.Value == 1) && boxTiles.Any(t => t.Value == 2) && boxTiles.Any(t => t.Value == 4) && boxTiles.Any(t => t.Value == 5) && boxTiles.Any(t => t.Value == 6))
                    {
                        validTiles.AddRange(boxTiles.Where(t => t.Value == 1 || t.Value == 2 || t.Value == 4 || t.Value == 5 || t.Value == 6));
                    }
                    break;

                default:
                    Debug.LogError("Sum is outside expected range");
                    break;
            }

            return validTiles.Distinct().ToList();
        }
    }
}