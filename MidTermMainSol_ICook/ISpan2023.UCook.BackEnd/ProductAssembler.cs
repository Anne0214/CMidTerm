using Ado.Net.SqlDataLayer;
using ISpan2023.UCook.BackEnd.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.UCook.BackEnd
{
    public static class Assembler
    {
        /// <summary>
        /// 將讀到的資料轉為ProductSearchDto的方法
        /// </summary>
        public static Func<SqlDataReader, ProductSearchDto> ProducSearchDtoAssembler
        {
            get
            {
                Func<SqlDataReader, ProductSearchDto> func = (reader) =>
                {
                    string spu = reader.GetString("SPU");
                    string productName = reader.GetString("PRODUCT_NAME商品名稱");
                    string category = reader.GetString("CATEGORY商品分類名稱");
                    string onShelf = reader.GetString("ON_SHELF上架狀態");
                    int salePrice = reader.GetInt("SALE_PRICE銷售價");
                    string allSku = reader.GetString("SKU");
                    int stockNumber = reader.GetInt("STOCK_NUMBER庫存數量");
                    int soldNumber = reader.GetInt("SOLD_NUMBER售出數量");
                    
    
                    return new ProductSearchDto
                    {   Spu = spu,
                        ProductName= productName,
                        Category= category,
                        OnShelf= onShelf,
                        SalePrice= salePrice,
                        AllSku = allSku ,
                        SoldNumber =soldNumber ,
                        StockNumber = stockNumber,
                    };

                };
                return func;
            }
        }

        public static Func<SqlDataReader, ProductDetailDto> ProductDetailDtoAssembler
        {
            get
            {
                Func<SqlDataReader, ProductDetailDto> func = (reader) =>
                { 
                    string cover = reader.GetString("img");
                    string category = reader.GetString("CATEGORY商品分類名稱");
                    string spu = reader.GetString("SPU");
                    string productName = reader.GetString("PRODUCT_NAME商品名稱");
                    string onShelf = reader.GetString("ON_SHELF上架狀態");
                    int purchasePrice = reader.GetInt("PURCHASE_PRICE採購價");
                    int tagPrice = reader.GetInt("TAG_PRICE吊牌價");
                    int salePrice = reader.GetInt("SALE_PRICE銷售價");
                    string productDescription = reader.GetString("PRODUCT_DESCRIPTION簡短商品說明");
                    string fullProductDescription = reader.GetString("FULL_PRODUCT_DESCRIPTION完整說明圖片");

                    return new ProductDetailDto()
                    {
                        Spu = spu,
                        Cover = cover,
                        Category = category,
                        ProductName = productName,
                        OnShelf = onShelf,
                        PurchasePrice = purchasePrice,
                        TagPrice = tagPrice,
                        SalePrice = salePrice,
                        ProductDescription = productDescription,
                        FullProductDescription = fullProductDescription,
                    };

                };
                return func;
            }
        }
    
        public static Func<SqlDataReader,SkuDto> SkuDtoAssembler
        {
            get
            {
                Func<SqlDataReader, SkuDto> func = (reader) =>
                {
                    string sku = reader.GetString("SKU");
                    string typeName = reader.GetString("TYPE_NAME型號");
                    int stockNumber = reader.GetInt("STOCK_NUMBER庫存數量");
                    int soldNumber = reader.GetInt("SOLD_NUMBER已售出數量");

                    return new SkuDto()
                    {
                        Sku = sku,
                        TypeName = typeName,
                        StockNumber = stockNumber,
                        SoldNumber = soldNumber
                    };
                };
                return func;
            }
        }
        public static Func<SqlDataReader,ProductCSVDto> ProductCSVDtoAssembler
        {
            get
            {
                Func<SqlDataReader, ProductCSVDto> func = (reader) =>
                {
                    string Cover = reader.GetString("img");
                    string Category = reader.GetString("CATEGORY商品分類名稱");
                    string Spu = reader.GetString("SPU");
                    string ProductName = reader.GetString("PRODUCT_NAME商品名稱");

                    //0:待上架,1:上架中,2:封存
                    string OnShelf = reader.GetString("ON_SHELF上架狀態");
                    int PurchasePrice = reader.GetInt("PURCHASE_PRICE採購價");
                    int TagPrice = reader.GetInt("TAG_PRICE吊牌價");
                    int SalePrice = reader.GetInt("SALE_PRICE銷售價");
                    string ProductDescription = reader.GetString("PRODUCT_DESCRIPTION簡短商品說明");
                    string FullProductDescription = reader.GetString("FULL_PRODUCT_DESCRIPTION完整說明圖片");
                    string Sku = reader.GetString("SKU");
                    string TypeName = reader.GetString("TYPE_NAME型號");
                    int StockNumber = reader.GetInt("STOCK_NUMBER庫存數量");
                    int SoldNumber = reader.GetInt("SOLD_NUMBER已售出數量");

                    return new ProductCSVDto
                    {
                        Cover = Cover,
                        Category = Category,
                        FullProductDescription = FullProductDescription,
                        OnShelf = OnShelf,
                        ProductDescription = ProductDescription,
                        ProductName = ProductName,
                        PurchasePrice = PurchasePrice,
                        SalePrice = SalePrice,
                        Sku = Sku,
                        SoldNumber = SoldNumber,
                        Spu = Spu,
                        StockNumber = StockNumber,
                        TagPrice = TagPrice,
                        TypeName = TypeName,
                    };
                };
                return func;
            }
        }
    }
}
