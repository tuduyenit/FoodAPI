using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodsOrderAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "Desc", "ImgSource", "Title" },
                values: new object[,]
                {
                    { 1, "French Fries, Any Kind of meat, Lettuce, Cheese, Sour Cream, Beans, Pico de Gallo, Avocado", "https://d1ralsognjng37.cloudfront.net/9dd6494b-84f6-4459-8b55-359d45f8723c.jpeg", "Wet Burrito" },
                    { 23, "Canton Element (Holborn) has a FHRS rating of 5. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website.", "https://d1ralsognjng37.cloudfront.net/1953227c-6829-4d6f-8db2-3ebbbd5641ca", "Stir Fried Scallops, King Prawns with Asparagus" },
                    { 24, "Korean traditional stir fried beef marinated in sweet soy sauce.", "https://d1ralsognjng37.cloudfront.net/601d7eff-0d52-4cc3-931c-f950e809d890", "Bulgogi" },
                    { 25, "Pan fried pork belly.", "https://d1ralsognjng37.cloudfront.net/f30d538c-10b2-4a92-a0ee-65842404581e", "Pork Belly" },
                    { 26, "Super spicy stir-fried chicken with mozzarella cheese.", "https://d1ralsognjng37.cloudfront.net/90e95fa8-6f74-43f6-8217-7775e6bc592a", "Cheese Buldak" },
                    { 27, "Korean traditional stir pork marinated in chilli.", "https://d1ralsognjng37.cloudfront.net/300c3919-b7e8-4550-803e-6e11a3b87d1a", "Jeyuk" },
                    { 28, "Steamed rice with assorted vegetables and fried egg in a bowl.", "https://d1ralsognjng37.cloudfront.net/f5a3cef7-2deb-4928-9501-1a86c2954e7d", "Bibimbab" },
                    { 29, "Stir fried squid and pork belly in chilli sauce.", "https://d1ralsognjng37.cloudfront.net/c45e56a1-b46c-4460-a0c9-65d5694b293e", "Osam Bulgogi" },
                    { 22, "Canton Element (Holborn) has a FHRS rating of 5. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website.", "https://d1ralsognjng37.cloudfront.net/f1d6d77d-9389-4e84-8fc5-fc2c589bf7d4", "Steamed Prawn, Zucchini Dumplings" },
                    { 30, "Deep fried chicken katsu with curry and steamed rice.", "https://d1ralsognjng37.cloudfront.net/03f8db8b-706b-472e-bba6-301b6587a724.jpeg", "Chicken katsu curry" },
                    { 32, "Yum Yum (Victoria) has a FHRS rating of 3. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website.", "https://d1ralsognjng37.cloudfront.net/cd4158c9-9c53-4bfe-884c-ddd9d0b87475", "King Prawn in Hot Sambal Sauce" },
                    { 33, "With one person. With bone in chicken and potatoes in a spicy sauce.", "https://d1ralsognjng37.cloudfront.net/15dd12e8-12af-45a7-a44e-e7b05d514d6a.jpeg", "Hand-Pulled Noodles, Xinjiang Style" },
                    { 34, "With tomato and egg sauce, and chilli oil.", "https://d1ralsognjng37.cloudfront.net/2cbb139d-37c0-4eab-ad21-39a834a517e0.jpeg", "Pork Biang Biang Noodles" },
                    { 35, "Samgyetang (Ginseng Chicken Soup) is a hot, steaming, very traditional Korean healthy dish which is served with whole Poussin stuffed with rice, garlic, and jujube in the chicken broth made with ginseng and herbal ingredients.", "https://d1ralsognjng37.cloudfront.net/01aaa7cb-e759-4046-be64-d9f3317feb07.jpeg", "Samgyetang(Ginseng chicken soup)" },
                    { 36, "With bamboo shoots, sesame seeds, soy sauce, and chilli oil. Also includes cucumber, radish, green and red pepper, wood ear mushroom, strawberry, tomato and lettuce.", "https://d1ralsognjng37.cloudfront.net/f369d010-b700-4b00-8325-d1860d56160b.jpeg", "Boneless Chicken in Ginger Sauce" },
                    { 37, "With cucumber, coriander, and sesame oil. Also includes cucumber, radish, green and red pepper, wood ear mushroom, strawberry, tomato and lettuce.", "https://d1ralsognjng37.cloudfront.net/37244986-10f9-4025-9f7a-a1748f4bf116.jpeg", "Xi’an Spicy Sliced Beef" },
                    { 38, "Samgyetang (Ginseng Chicken Soup) is a hot, steaming, very traditional Korean healthy dish which is served with whole Poussin stuffed with rice, garlic, and jujube in the chicken broth made with ginseng and herbal ingredients.", "https://d1ralsognjng37.cloudfront.net/c85cf098-f897-4e52-8036-2dd002e09afb.jpeg", "With green peppers, red peppers, cucumber, spring onion, and beansprouts." },
                    { 31, "Medium sized noodles with mixed seafood in chicken soup.", "https://d1ralsognjng37.cloudfront.net/abaee2a3-beb2-4e14-b194-d0b1af4b0901", "Jampong" },
                    { 21, "Six pieces. Prawn, vegetarian, chive and prawn, scallop and prawn, zucchini and prawn, and spinach dumpling.", "https://d1ralsognjng37.cloudfront.net/6cd12011-8025-4188-a787-f0e61a972448", "Dim Sum Platter" },
                    { 20, "With fried rice, boiled rice, or lo mein. + 1 CocaCola.", "https://d1ralsognjng37.cloudfront.net/73ae7d02-586c-46e7-8fbf-228135920d8e.jpeg", "Salt and Pepper Spices Half and Half" },
                    { 19, "Served with your choice of Coca-Cola product.", "https://d1ralsognjng37.cloudfront.net/64c53582-f3a4-4180-ae58-588b09b66c48.jpeg", "Szechuan Beef Noodle Soup" },
                    { 2, "Rice, Beans, Avocado, Sour Cream, Cheese, Hot Salsa, Onions and Choice of Meat.", "https://d1ralsognjng37.cloudfront.net/e05d185a-cca5-418e-b12d-4896e0e76100.jpeg", "Super Burrito de Carne" },
                    { 3, "French Fries, Any Kind of meat, Lettuce, Cheese, Sour Cream, Beans, Pico de Gallo, Avocado.", "https://d1ralsognjng37.cloudfront.net/8271ecd9-5999-45ef-94bd-9548e20e2cc8", "Shrimp Dumplings" },
                    { 4, "Prawns, beef, and chicken. Hot and spicy. Served with your choice of Coca-Cola product.", "https://d1ralsognjng37.cloudfront.net/afe3299b-3d2c-42ae-bc2b-49ebae6f2a08.jpeg", "House Spicy Chow Mein Bundle" },
                    { 5, "Prawns, beef, and chicken. Served with your choice of Coca-Cola product.", "https://d1ralsognjng37.cloudfront.net/df537120-d788-4c91-850d-7cfb36383aee", "House Chow Mein Bundle" },
                    { 6, "Full-bodied, fragrant, and tropical. Organic ceremonial matcha. When autocomplete results are available, use up and down arrows to review and enter to select. Touch device users, explore by touch or with swipe gestures.", "https://d1ralsognjng37.cloudfront.net/d620f5a2-7447-4661-995b-b5d72f30496a", "Mango Matcha Latte" },
                    { 7, "Fried rice, with a coca-cola product.", "https://d1ralsognjng37.cloudfront.net/f03c0162-9526-4b07-bebe-4cede928e7a5", "Mango Matcha Latte" },
                    { 8, "Fried. Served with your choice of Coca-Cola Product.", "https://d1ralsognjng37.cloudfront.net/16fb7fa3-2b14-4636-a479-f906062f552e.jpeg", "Procoly Ahu" },
                    { 9, "Our rich espresso marked with dollop of steamed milk and foam. A European-style classic.", "https://d1ralsognjng37.cloudfront.net/c75bb883-af05-4769-ab20-679274f4d969.jpeg", "Espresso Macchiato" },
                    { 10, "Roasted Duck Bejing Formular.", "https://d1ralsognjng37.cloudfront.net/a0ebf83a-234a-475b-95ea-4f05249a7b0b", "Roasted Duck" },
                    { 11, "Noodle Soup with Wonton. Served with choice of Congee.", "https://d1ralsognjng37.cloudfront.net/b4b84466-4ce7-4423-8852-388c6443ef93.jpeg", "Noodle Soup with Wonton + Choice of Congee" },
                    { 12, "Pork BBQ Triple Combination . Coffee or CocaCola.", "https://d1ralsognjng37.cloudfront.net/5ccbfe25-5235-491f-92b6-06277e862332", "BBQ Triple Combination" },
                    { 13, "Vietnam food - Pho famous", "https://d1ralsognjng37.cloudfront.net/3df9fe44-d810-4d19-a63e-9615eb7fb999.jpeg", "Dry Beef Pho - Phở xào bò" },
                    { 14, "Minced Beef with Chinese Parsley Soup - Server with Chinese Wine", "https://d1ralsognjng37.cloudfront.net/3b16e7d8-4890-490b-ad7d-26832be05bf0", "Minced Beef with Chinese Parsley Soup" },
                    { 15, "Salt and Pepper Lobster + 4 cans Tiger Beer", "https://d1ralsognjng37.cloudfront.net/8d0d39a4-9268-4124-912e-e3f39a945270", "Salt and Pepper Lobster" },
                    { 16, "Served with your choice of Coca-Cola product.", "https://d1ralsognjng37.cloudfront.net/91ac561a-d34a-4381-9718-f944bfdd8f36", "3 Kinds of BBQ Combinate Plate 三宝饭 Bundle" },
                    { 17, "Served with your choice of Coca-Cola product.", "https://d1ralsognjng37.cloudfront.net/65e2c21b-bd5c-4439-86cf-3ec2a2747186", "BBQ Pork" },
                    { 18, "Served with your choice of Coca-Cola product.", "https://d1ralsognjng37.cloudfront.net/c93f79b6-b097-49b2-8f33-a169ff9463c9.jpeg", "BBQ Pork Mix Combo" },
                    { 39, "Filled with assorted vegetables, bean thread noodles, and chicken.", "https://d1ralsognjng37.cloudfront.net/3d5a0d40-c76c-48ac-b8ed-2638774a7d37.jpeg", "Chicken Spring Rolls" },
                    { 40, "Bánh tráng, xoài, trứng cút, tôm khô, rau thơm + 1 CocaCola", "https://media.cooky.vn/recipe/g1/1615/s480x480/recipe1615-prepare-step3-636520093053653228.jpg", "Bánh tráng trộn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
