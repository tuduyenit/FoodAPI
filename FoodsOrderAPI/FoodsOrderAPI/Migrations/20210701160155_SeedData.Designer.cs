// <auto-generated />
using FoodsOrderAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodsOrderAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210701160155_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodsOrderAPI.Models.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desc = "French Fries, Any Kind of meat, Lettuce, Cheese, Sour Cream, Beans, Pico de Gallo, Avocado",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/9dd6494b-84f6-4459-8b55-359d45f8723c.jpeg",
                            Title = "Wet Burrito"
                        },
                        new
                        {
                            Id = 2,
                            Desc = "Rice, Beans, Avocado, Sour Cream, Cheese, Hot Salsa, Onions and Choice of Meat.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/e05d185a-cca5-418e-b12d-4896e0e76100.jpeg",
                            Title = "Super Burrito de Carne"
                        },
                        new
                        {
                            Id = 3,
                            Desc = "French Fries, Any Kind of meat, Lettuce, Cheese, Sour Cream, Beans, Pico de Gallo, Avocado.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/8271ecd9-5999-45ef-94bd-9548e20e2cc8",
                            Title = "Shrimp Dumplings"
                        },
                        new
                        {
                            Id = 4,
                            Desc = "Prawns, beef, and chicken. Hot and spicy. Served with your choice of Coca-Cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/afe3299b-3d2c-42ae-bc2b-49ebae6f2a08.jpeg",
                            Title = "House Spicy Chow Mein Bundle"
                        },
                        new
                        {
                            Id = 5,
                            Desc = "Prawns, beef, and chicken. Served with your choice of Coca-Cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/df537120-d788-4c91-850d-7cfb36383aee",
                            Title = "House Chow Mein Bundle"
                        },
                        new
                        {
                            Id = 6,
                            Desc = "Full-bodied, fragrant, and tropical. Organic ceremonial matcha. When autocomplete results are available, use up and down arrows to review and enter to select. Touch device users, explore by touch or with swipe gestures.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/d620f5a2-7447-4661-995b-b5d72f30496a",
                            Title = "Mango Matcha Latte"
                        },
                        new
                        {
                            Id = 7,
                            Desc = "Fried rice, with a coca-cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/f03c0162-9526-4b07-bebe-4cede928e7a5",
                            Title = "Mango Matcha Latte"
                        },
                        new
                        {
                            Id = 8,
                            Desc = "Fried. Served with your choice of Coca-Cola Product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/16fb7fa3-2b14-4636-a479-f906062f552e.jpeg",
                            Title = "Procoly Ahu"
                        },
                        new
                        {
                            Id = 9,
                            Desc = "Our rich espresso marked with dollop of steamed milk and foam. A European-style classic.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/c75bb883-af05-4769-ab20-679274f4d969.jpeg",
                            Title = "Espresso Macchiato"
                        },
                        new
                        {
                            Id = 10,
                            Desc = "Roasted Duck Bejing Formular.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/a0ebf83a-234a-475b-95ea-4f05249a7b0b",
                            Title = "Roasted Duck"
                        },
                        new
                        {
                            Id = 11,
                            Desc = "Noodle Soup with Wonton. Served with choice of Congee.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/b4b84466-4ce7-4423-8852-388c6443ef93.jpeg",
                            Title = "Noodle Soup with Wonton + Choice of Congee"
                        },
                        new
                        {
                            Id = 12,
                            Desc = "Pork BBQ Triple Combination . Coffee or CocaCola.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/5ccbfe25-5235-491f-92b6-06277e862332",
                            Title = "BBQ Triple Combination"
                        },
                        new
                        {
                            Id = 13,
                            Desc = "Vietnam food - Pho famous",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/3df9fe44-d810-4d19-a63e-9615eb7fb999.jpeg",
                            Title = "Dry Beef Pho - Phở xào bò"
                        },
                        new
                        {
                            Id = 14,
                            Desc = "Minced Beef with Chinese Parsley Soup - Server with Chinese Wine",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/3b16e7d8-4890-490b-ad7d-26832be05bf0",
                            Title = "Minced Beef with Chinese Parsley Soup"
                        },
                        new
                        {
                            Id = 15,
                            Desc = "Salt and Pepper Lobster + 4 cans Tiger Beer",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/8d0d39a4-9268-4124-912e-e3f39a945270",
                            Title = "Salt and Pepper Lobster"
                        },
                        new
                        {
                            Id = 16,
                            Desc = "Served with your choice of Coca-Cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/91ac561a-d34a-4381-9718-f944bfdd8f36",
                            Title = "3 Kinds of BBQ Combinate Plate 三宝饭 Bundle"
                        },
                        new
                        {
                            Id = 17,
                            Desc = "Served with your choice of Coca-Cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/65e2c21b-bd5c-4439-86cf-3ec2a2747186",
                            Title = "BBQ Pork"
                        },
                        new
                        {
                            Id = 18,
                            Desc = "Served with your choice of Coca-Cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/c93f79b6-b097-49b2-8f33-a169ff9463c9.jpeg",
                            Title = "BBQ Pork Mix Combo"
                        },
                        new
                        {
                            Id = 19,
                            Desc = "Served with your choice of Coca-Cola product.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/64c53582-f3a4-4180-ae58-588b09b66c48.jpeg",
                            Title = "Szechuan Beef Noodle Soup"
                        },
                        new
                        {
                            Id = 20,
                            Desc = "With fried rice, boiled rice, or lo mein. + 1 CocaCola.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/73ae7d02-586c-46e7-8fbf-228135920d8e.jpeg",
                            Title = "Salt and Pepper Spices Half and Half"
                        },
                        new
                        {
                            Id = 21,
                            Desc = "Six pieces. Prawn, vegetarian, chive and prawn, scallop and prawn, zucchini and prawn, and spinach dumpling.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/6cd12011-8025-4188-a787-f0e61a972448",
                            Title = "Dim Sum Platter"
                        },
                        new
                        {
                            Id = 22,
                            Desc = "Canton Element (Holborn) has a FHRS rating of 5. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/f1d6d77d-9389-4e84-8fc5-fc2c589bf7d4",
                            Title = "Steamed Prawn, Zucchini Dumplings"
                        },
                        new
                        {
                            Id = 23,
                            Desc = "Canton Element (Holborn) has a FHRS rating of 5. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/1953227c-6829-4d6f-8db2-3ebbbd5641ca",
                            Title = "Stir Fried Scallops, King Prawns with Asparagus"
                        },
                        new
                        {
                            Id = 24,
                            Desc = "Korean traditional stir fried beef marinated in sweet soy sauce.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/601d7eff-0d52-4cc3-931c-f950e809d890",
                            Title = "Bulgogi"
                        },
                        new
                        {
                            Id = 25,
                            Desc = "Pan fried pork belly.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/f30d538c-10b2-4a92-a0ee-65842404581e",
                            Title = "Pork Belly"
                        },
                        new
                        {
                            Id = 26,
                            Desc = "Super spicy stir-fried chicken with mozzarella cheese.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/90e95fa8-6f74-43f6-8217-7775e6bc592a",
                            Title = "Cheese Buldak"
                        },
                        new
                        {
                            Id = 27,
                            Desc = "Korean traditional stir pork marinated in chilli.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/300c3919-b7e8-4550-803e-6e11a3b87d1a",
                            Title = "Jeyuk"
                        },
                        new
                        {
                            Id = 28,
                            Desc = "Steamed rice with assorted vegetables and fried egg in a bowl.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/f5a3cef7-2deb-4928-9501-1a86c2954e7d",
                            Title = "Bibimbab"
                        },
                        new
                        {
                            Id = 29,
                            Desc = "Stir fried squid and pork belly in chilli sauce.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/c45e56a1-b46c-4460-a0c9-65d5694b293e",
                            Title = "Osam Bulgogi"
                        },
                        new
                        {
                            Id = 30,
                            Desc = "Deep fried chicken katsu with curry and steamed rice.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/03f8db8b-706b-472e-bba6-301b6587a724.jpeg",
                            Title = "Chicken katsu curry"
                        },
                        new
                        {
                            Id = 31,
                            Desc = "Medium sized noodles with mixed seafood in chicken soup.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/abaee2a3-beb2-4e14-b194-d0b1af4b0901",
                            Title = "Jampong"
                        },
                        new
                        {
                            Id = 32,
                            Desc = "Yum Yum (Victoria) has a FHRS rating of 3. This information was updated on 14/05/2020. The current rating is on their page on the FSA Website.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/cd4158c9-9c53-4bfe-884c-ddd9d0b87475",
                            Title = "King Prawn in Hot Sambal Sauce"
                        },
                        new
                        {
                            Id = 33,
                            Desc = "With one person. With bone in chicken and potatoes in a spicy sauce.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/15dd12e8-12af-45a7-a44e-e7b05d514d6a.jpeg",
                            Title = "Hand-Pulled Noodles, Xinjiang Style"
                        },
                        new
                        {
                            Id = 34,
                            Desc = "With tomato and egg sauce, and chilli oil.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/2cbb139d-37c0-4eab-ad21-39a834a517e0.jpeg",
                            Title = "Pork Biang Biang Noodles"
                        },
                        new
                        {
                            Id = 35,
                            Desc = "Samgyetang (Ginseng Chicken Soup) is a hot, steaming, very traditional Korean healthy dish which is served with whole Poussin stuffed with rice, garlic, and jujube in the chicken broth made with ginseng and herbal ingredients.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/01aaa7cb-e759-4046-be64-d9f3317feb07.jpeg",
                            Title = "Samgyetang(Ginseng chicken soup)"
                        },
                        new
                        {
                            Id = 36,
                            Desc = "With bamboo shoots, sesame seeds, soy sauce, and chilli oil. Also includes cucumber, radish, green and red pepper, wood ear mushroom, strawberry, tomato and lettuce.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/f369d010-b700-4b00-8325-d1860d56160b.jpeg",
                            Title = "Boneless Chicken in Ginger Sauce"
                        },
                        new
                        {
                            Id = 37,
                            Desc = "With cucumber, coriander, and sesame oil. Also includes cucumber, radish, green and red pepper, wood ear mushroom, strawberry, tomato and lettuce.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/37244986-10f9-4025-9f7a-a1748f4bf116.jpeg",
                            Title = "Xi’an Spicy Sliced Beef"
                        },
                        new
                        {
                            Id = 38,
                            Desc = "Samgyetang (Ginseng Chicken Soup) is a hot, steaming, very traditional Korean healthy dish which is served with whole Poussin stuffed with rice, garlic, and jujube in the chicken broth made with ginseng and herbal ingredients.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/c85cf098-f897-4e52-8036-2dd002e09afb.jpeg",
                            Title = "With green peppers, red peppers, cucumber, spring onion, and beansprouts."
                        },
                        new
                        {
                            Id = 39,
                            Desc = "Filled with assorted vegetables, bean thread noodles, and chicken.",
                            ImgSource = "https://d1ralsognjng37.cloudfront.net/3d5a0d40-c76c-48ac-b8ed-2638774a7d37.jpeg",
                            Title = "Chicken Spring Rolls"
                        },
                        new
                        {
                            Id = 40,
                            Desc = "Bánh tráng, xoài, trứng cút, tôm khô, rau thơm + 1 CocaCola",
                            ImgSource = "https://media.cooky.vn/recipe/g1/1615/s480x480/recipe1615-prepare-step3-636520093053653228.jpg",
                            Title = "Bánh tráng trộn"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
