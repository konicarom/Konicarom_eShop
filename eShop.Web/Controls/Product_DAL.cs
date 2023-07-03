using System.Data;
using System.Xml.Linq;
using static MudBlazor.CategoryTypes;

namespace eShop.Web.Controls
{
    public class Product_DAL
    {
        DataAccess DAC = new DataAccess();
        string[] name = { }; //Luu ten cac tham so
        object[] value = { }; //Mang luu gia tri cac tham so
        public int Insert(int Id, string Brand, string Name, double Price, string ImageLink, string Description)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@productid";
            name[1] = "@brand";
            name[2] = "@name";
            name[3] = "@price";
            name[4] = "@imagelink";
            name[5] = "@description";

            value[0] = Id;
            value[1] = Brand;
            value[2] = Name;
            value[3] = Price;
            value[4] = ImageLink;
            value[5] = Description;

            return DAC.Thuchien_HanhDong("InsertProduct", name, value, 6);
        }

        //public int Delete(string Id)
        //{
        //    name = new string[1];
        //    value = new object[1];
        //    name[0] = "@productid";
        //    value[0] = Id;
        //    return DAC.Thuchien_HanhDong("DeleteProduct", name, value, 1);
        //}

        //public int Update(int Id, string Name, double Price, string ImageLink, int Rating, string Date, string Tier)
        //{
        //    name = new string[7];
        //    value = new object[7];
        //    name[0] = "@productid";
        //    name[1] = "@name";
        //    name[2] = "@price";
        //    name[3] = "@imagelink";
        //    name[4] = "@rating";
        //    name[5] = "@date";
        //    name[6] = "@tier";

        //    value[0] = Id;
        //    value[1] = Name;
        //    value[2] = Price;
        //    value[3] = ImageLink;
        //    value[4] = Rating;
        //    value[5] = Date;
        //    value[6] = Tier;
        //    return DAC.Thuchien_HanhDong("UpdateProduct", name, value, 7);
        //}
    }
}
