using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProductDetail
{
    public static string name;
    public static string price;

    public static void GetProductDetails(string prodName){
        switch(prodName){
            case ("Prod_RomanyCreams"):
            {
                name = "Romany Creams";
                price = "R28.99";
            }
            break;
            case ("Prod_SpecialK"):
            {
                name = "Special K - Cereal Bars";
                price = "R19.50";
            }
            break;
            case ("Cat_Beans"):
            {
                name = "Baked Beans";
                price = "R36.00";
            }
            break;
            case ("Cat_Beer"):
            {
                name = "Heineken";
                price = "R259.00";
            }
            break;
            case ("Cat_Bleach"):
            {
                name = "Domestos Bleach";
                price = "R21.00";
            }
            break;
            case ("Cat_Chips"):
            {
                name = "NikNaks";
                price = "R34.00";
            }
            break;
            case ("Cat_Coffee"):
            {
                name = "Ricoffy";
                price = "R66.00";
            }
            break;
            case ("Cat_Grandpa"):
            {
                name = "Grand-pa Powder";
                price = "R153.00";
            }
            break;
            case ("Cat_Maize"):
            {
                name = "Nyala Maize Meal";
                price = "R48.00";
            }
            break;
            case ("Cat_Milk"):
            {
                name = "Full Cream Milk";
                price = "R69.00";
            }
            break;
            case ("Cat_Rice"):
            {
                name = "Spekko - Rice";
                price = "R79.00";
            }
            break;
            case ("Cat_Soda1"):
            {
                name = "Soft Drinks";
                price = "R165.00";
            }
            break;
            case ("Cat_Soda2"):
            {
                name = "Soft Drinks Suger Free";
                price = "R154.00";
            }
            break;
            case ("Cat_Sweets"):
            {
                name = "Beacon Mini Prepacks";
                price = "R150.00";
            }
            break;
            case ("Cat_WashingPowder"):
            {
                name = "Sunlight Washing Powder";
                price = "R35.00";
            }
            break;
            case ("Cat_Level"):
            {
                name = "Ross Artisan Level 450mm";
                price = "R95.00";
            }
            break;
            case ("Cat_BuildersCompressionElbow"):
            {
                name = "Builders Compression Elbow Wallplate CXFI";
                price = "R70.00";
            }
            break;
            case ("Cat_Grip3-30"):
            {
                name = "Grip 3-30mm Pipe Cutter";
                price = "R200.00";
            }
            break;
            case ("Cat_CopperTube"):
            {
                name = "Copper tube Len 460/2";
                price = "R160.00";
            }
            break;
            case ("Cat_ElliesSunflower"):
            {
                name = "Ellies Sunflower Shower Head - Chrome (180 mm)";
                price = "R141.00";
            }
            break;
            case ("Cat_showerArm"):
            {
                name = "Shower Arm Standard";
                price = "R141.00";
            }
            break;
            case ("Cat_buildersStop"):
            {
                name = "Builders Stop Tap Rb FXF (15mm)";
                price = "R240.00";
            }
            break;
            case ("Cat_buildersCompression"):
            {
                name = "Builders Compression Tee Reducer";
                price = "R87.00";
            }
            break;
            case ("Cat_ptfeh"):
            {
                name = "Builders Ptfetch Roll Tee Reducer";
                price = "R40.00";
            }
            break;
            case ("Cat_GripPliers"):
            {
                name = "Grip Pliers Water Pump 250 mm";
                price = "R185.00";
            }
            break;
            case ("Cat_200mmAdjustable"):
            {
                name = "200mm Adjustable Wrench";
                price = "R150.00";
            }
            break;

        }
    }
}
