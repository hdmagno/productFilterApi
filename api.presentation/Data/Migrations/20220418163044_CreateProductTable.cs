using Microsoft.EntityFrameworkCore.Migrations;

namespace presentation.Data.Migrations
{
    public partial class CreateProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 1, "Molestias dolor rerum ut. Dolor rerum pariatur fugit nemo quaerat. Quia aut et quo nemo dolor impedit fugit dolor. Et suscipit quis ipsam aut repellat dolores.", "http://lorempixel.com/640/480/transport", 46f, "velit" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 28, "Asperiores quis in facilis facere qui quo expedita numquam. Fugit sequi consequatur deserunt. Qui voluptatum autem possimus eum soluta at fugit. Natus eos alias porro non qui exercitationem facilis sed a. Pariatur eligendi repudiandae sint ex non dolores repellendus quos doloremque.", "http://lorempixel.com/640/480/food", 34f, "voluptatem" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 29, "Et ut quas saepe. Eos ipsum et vitae. Qui repellat qui qui repudiandae totam tenetur.", "http://lorempixel.com/640/480/technics", 69f, "amet" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 30, "Vero ea ullam unde quasi fuga sint. Accusamus vel fuga qui. Veritatis eos nemo quibusdam. Cum veritatis eum ut provident provident ea delectus culpa. Qui esse non corporis quos soluta autem.", "http://lorempixel.com/640/480/animals", 64f, "repellendus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 31, "Quo molestiae maxime aut quis repellat libero. Sit est illo vero odit facilis minus a accusamus. Qui odit quae ex impedit qui veniam quia labore.", "http://lorempixel.com/640/480/nightlife", 72f, "est" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 32, "Minus dolores aliquid et. Cupiditate nesciunt voluptate ullam. Incidunt aut commodi tempore adipisci nulla hic quam. Dolorem totam sapiente et. Eius exercitationem est ab omnis.", "http://lorempixel.com/640/480/business", 24f, "eaque" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 33, "Quia aut exercitationem dolorem et ut laborum id consequatur. Quia ut dicta laborum consequuntur. Occaecati enim consequatur aut quisquam assumenda. Asperiores nobis eos quibusdam odit facilis aspernatur error. Accusamus et omnis eius omnis quia et aut numquam qui. Sit incidunt ipsam quia.", "http://lorempixel.com/640/480/animals", 94f, "nostrum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 34, "Atque illo qui aliquid laboriosam ullam qui earum unde quas. Impedit facere sit. Officia inventore et. Qui et molestiae libero asperiores et qui omnis quis. Nobis dolor ad quam tempore blanditiis vel ex.", "http://lorempixel.com/640/480/business", 90f, "consequatur" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 35, "Suscipit impedit rerum ducimus molestiae quae minima dolorum. Voluptatem provident veniam. Iste eum voluptatem id. Ut est nostrum eos voluptas vel quis vitae qui modi. Eos accusantium qui velit. Deserunt a aliquid dolorem accusantium quo sunt aperiam et nesciunt.", "http://lorempixel.com/640/480/nature", 22f, "aliquam" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 36, "Quia laudantium doloribus porro non eum. Eum dolorem neque ut voluptatem inventore. Adipisci asperiores rerum officiis quaerat delectus. Quibusdam similique et dolorem soluta aliquam. Dolorem quasi ratione est. Autem accusantium in aperiam accusamus velit mollitia sed in.", "http://lorempixel.com/640/480/nightlife", 10f, "et" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 37, "Est iusto neque. Voluptatem ipsum itaque alias voluptate saepe consequuntur necessitatibus non. Labore numquam facere perferendis. Dolores ut ea quibusdam sapiente beatae tempore distinctio.", "http://lorempixel.com/640/480/sports", 87f, "cum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 38, "Et et est quibusdam. Enim aut voluptatum. Temporibus et molestias et reiciendis libero totam aut ea omnis. Reiciendis eveniet voluptas quis rerum sed quisquam deserunt excepturi sunt. Eos voluptas earum praesentium.", "http://lorempixel.com/640/480/technics", 57f, "ut" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 39, "Magni modi id voluptatum quod nostrum. Aspernatur consequatur consectetur. Corrupti quos sunt quia provident rerum quia sequi et unde.", "http://lorempixel.com/640/480/cats", 97f, "dignissimos" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 40, "Dolor delectus occaecati temporibus hic iusto. Nostrum eos possimus exercitationem. Perspiciatis aliquid voluptatem fuga officia. Consequuntur distinctio est possimus minus. Doloribus adipisci quis voluptate recusandae quo aliquam aut fugiat ut.", "http://lorempixel.com/640/480/animals", 17f, "et" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 41, "Non laboriosam sed quo. Labore animi dolor aut et molestiae. Facilis tempore reiciendis eum nihil ut deserunt et.", "http://lorempixel.com/640/480/nature", 23f, "culpa" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 42, "Et quos qui. Labore et ipsa autem beatae. Quia ducimus ipsa minima est reprehenderit esse. Facere aut dolores est magni vero.", "http://lorempixel.com/640/480/food", 72f, "maxime" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 43, "Corrupti vel deserunt nulla est hic. Ratione quas error officia aut sit similique architecto. Eum vel a ut voluptate laboriosam nam doloribus. Necessitatibus saepe commodi mollitia voluptas. Numquam inventore a deserunt eius minus id. Sit rerum dolore repudiandae et.", "http://lorempixel.com/640/480/business", 21f, "pariatur" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 44, "Velit ab nemo. Vitae consequatur ratione quo animi dolores et inventore eum unde. Perferendis quis dolorem quis aut at molestiae dolor.", "http://lorempixel.com/640/480/abstract", 67f, "aut" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 45, "Maxime dolorem modi dicta pariatur nemo. Temporibus et quia aut hic dignissimos. Magni aut omnis enim natus cumque aliquam.", "http://lorempixel.com/640/480/technics", 82f, "a" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 46, "Velit ad enim. Ut quia pariatur quisquam ut. Enim porro quia architecto voluptatem accusamus assumenda ab pariatur. Non aliquid autem libero rem ex.", "http://lorempixel.com/640/480/food", 51f, "ullam" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 47, "Et et dolor. Quia occaecati a. Pariatur aut est. Ex quo quo veritatis atque omnis eum. Maxime ducimus perferendis sed. Deleniti animi vel voluptates est reprehenderit unde dolores maxime.", "http://lorempixel.com/640/480/city", 15f, "ipsum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 48, "Aliquid vel doloribus. Voluptatem aut illum. Eum harum nostrum repudiandae et temporibus. Veniam rem quidem et quaerat rerum sint ratione. Consequuntur impedit quia in. Quos est quidem sint cupiditate aperiam voluptas.", "http://lorempixel.com/640/480/nature", 50f, "molestiae" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 27, "Fugit ut et molestiae quibusdam non dolores. Natus enim dolor et autem. Optio qui natus. Dolor est mollitia.", "http://lorempixel.com/640/480/nature", 65f, "dolor" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 26, "Voluptas ut id sequi dolor sit aut sit. Id cupiditate assumenda. Eaque facilis itaque architecto rem vero vel explicabo.", "http://lorempixel.com/640/480/animals", 29f, "pariatur" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 25, "Dolor accusamus sequi odit quisquam aut omnis ut itaque voluptas. Dolor qui ut sit. Neque quidem soluta corporis dolores quaerat possimus magnam velit.", "http://lorempixel.com/640/480/sports", 38f, "eveniet" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 24, "Sapiente et at odit totam atque recusandae provident beatae. Odio reprehenderit id et et. Eos sint ut. Aperiam est molestiae cupiditate et nobis sunt sapiente velit. Consequuntur et quo corporis consequatur. Commodi rerum porro totam dignissimos amet fuga.", "http://lorempixel.com/640/480/cats", 79f, "doloribus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 2, "Sed natus ut rerum veritatis esse similique. Minima perferendis qui molestias est. Aperiam eveniet incidunt aut corrupti. Qui recusandae maxime est soluta. Architecto hic aliquid.", "http://lorempixel.com/640/480/animals", 92f, "unde" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 3, "Assumenda ut ducimus libero porro exercitationem perspiciatis et exercitationem. Est omnis ut illum sapiente animi. Animi inventore adipisci ratione ut vel expedita a.", "http://lorempixel.com/640/480/transport", 40f, "impedit" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 4, "Aut voluptatem ad repellat. Nobis qui error dicta consectetur temporibus delectus. Quia alias ut unde quaerat maiores facere velit. Est eaque harum quas provident. Impedit maxime a et iusto nesciunt enim qui et. Corporis ad ratione ipsum excepturi accusamus ea.", "http://lorempixel.com/640/480/business", 67f, "dolorum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 5, "Nihil beatae quidem. Est aut quis labore. Aut voluptatem distinctio at laboriosam. Et non voluptatum perferendis. In alias a impedit est labore.", "http://lorempixel.com/640/480/sports", 81f, "corrupti" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 6, "Quae eos expedita voluptatem debitis quis adipisci iusto quas. Voluptatem dolor nostrum quia. Voluptatem ipsum harum sed et sequi. Labore et quam quia molestiae harum.", "http://lorempixel.com/640/480/nightlife", 11f, "harum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 7, "Qui odit cupiditate velit voluptatem ea culpa sit ipsa excepturi. Eos dolorem nam qui. Et dolorum ratione. Autem porro similique. Alias eveniet facere ea natus hic corrupti dolorum et voluptatem.", "http://lorempixel.com/640/480/animals", 11f, "deserunt" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 8, "Enim a quia fugit. Aperiam excepturi mollitia blanditiis laboriosam excepturi error qui dignissimos excepturi. Nihil sed fuga.", "http://lorempixel.com/640/480/business", 21f, "sapiente" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 9, "Sunt accusantium qui atque natus sint sunt nesciunt et. Debitis eos rem id est et. Corporis exercitationem sit ab eum sunt.", "http://lorempixel.com/640/480/business", 22f, "id" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 10, "Laboriosam et doloremque nam id omnis. Itaque qui doloremque. Earum assumenda ex. Molestiae similique autem est illum non possimus impedit qui. Sed quisquam nihil recusandae voluptate.", "http://lorempixel.com/640/480/city", 48f, "qui" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 11, "Aut odio non in et culpa libero esse praesentium. Ex magnam eligendi fuga dolorem. Voluptas quos et unde culpa non non.", "http://lorempixel.com/640/480/city", 58f, "temporibus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 49, "Ipsa assumenda dolor. Consequatur atque omnis iusto laudantium officiis molestiae. Quo iure iusto libero. Officiis est harum esse eum laboriosam eos expedita in. Facere autem non accusantium earum excepturi.", "http://lorempixel.com/640/480/business", 64f, "optio" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 12, "Quae nobis dolorum. Cum sed debitis corrupti. Aut est ut quaerat nisi. Iste tenetur tenetur accusantium vitae.", "http://lorempixel.com/640/480/nature", 82f, "eum" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 14, "Et laboriosam sunt unde temporibus nesciunt. Quaerat alias porro in. Veniam nostrum aperiam molestiae quia tempore. Earum odio et sed quam maxime nobis dolores cumque eligendi. Deleniti quod et sed itaque.", "http://lorempixel.com/640/480/technics", 23f, "repudiandae" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 15, "Ab officiis exercitationem quos soluta illo qui. Itaque dolorem pariatur aut sapiente. Earum alias et libero aut aut voluptatem sint error. Ut fugiat quibusdam vitae ex eos minima molestiae.", "http://lorempixel.com/640/480/city", 47f, "optio" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 16, "Quae quod est eos temporibus omnis non. Cum omnis pariatur quaerat recusandae explicabo. Saepe non excepturi sed enim iste. Nulla quaerat id doloribus et. Quam qui omnis repudiandae autem et facere non fugit et.", "http://lorempixel.com/640/480/cats", 78f, "saepe" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 17, "Inventore rerum qui quam ipsa quibusdam sed. Eveniet ex aliquam perferendis. Saepe et quia et sapiente rerum asperiores tempora tempora. Rerum et laboriosam omnis omnis ut minima dolor ad ut.", "http://lorempixel.com/640/480/nature", 81f, "aperiam" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 18, "Possimus sunt rerum nemo et iste sed. Sapiente aperiam nobis sed et autem. Voluptas sit fugiat aut itaque et. Et possimus quia dolorum in reiciendis dolor sunt. Quia quia incidunt. Omnis odit et sunt.", "http://lorempixel.com/640/480/city", 79f, "enim" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 19, "Explicabo pariatur nulla doloribus rerum et consequatur. Ullam reiciendis est illo nulla consequuntur magni aperiam voluptatibus qui. Officiis non natus voluptates sed officia quo modi. Quaerat harum ipsum voluptas voluptas est.", "http://lorempixel.com/640/480/people", 39f, "beatae" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 20, "Debitis quisquam ratione. Tempora qui voluptatem impedit voluptatibus temporibus ut qui fuga. Quas officia provident itaque facilis in. Soluta a optio. Consequatur aut est sed praesentium aut quaerat qui.", "http://lorempixel.com/640/480/abstract", 79f, "est" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 21, "Nobis et iusto magni et dolorum porro ut. In qui eos dolores eum magni amet. Adipisci voluptas ducimus. Quam omnis molestiae officia. Voluptatibus minima alias in soluta ex aut. Aliquam accusantium delectus sint odio laboriosam voluptatibus et voluptatem.", "http://lorempixel.com/640/480/food", 92f, "voluptatem" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 22, "Magni non repellat similique iure suscipit. Voluptatem voluptas aut ut quisquam quidem iusto. Ut porro totam suscipit. Magni odit modi dolores facere.", "http://lorempixel.com/640/480/food", 52f, "voluptatibus" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 23, "Cupiditate est consectetur natus voluptatem. In fugit delectus totam eius doloribus amet tenetur autem. Cumque perspiciatis velit nostrum est iusto est doloribus.", "http://lorempixel.com/640/480/cats", 12f, "est" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 13, "Perspiciatis labore tempore incidunt at et explicabo ut nam quis. Facilis quia sunt nesciunt maxime cum magnam temporibus assumenda. Quis labore a et ea culpa et ut. Dolore aut eligendi voluptatem. Exercitationem quia quaerat quas. Harum ut deserunt.", "http://lorempixel.com/640/480/transport", 53f, "culpa" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "Title" },
                values: new object[] { 50, "Ipsam tempora velit delectus qui et ut. Aut dolores animi expedita repudiandae sunt. Aut et non. Voluptatem sapiente velit aspernatur consequatur veritatis. Pariatur atque libero atque autem nostrum cumque enim natus vel. Qui est quisquam sint.", "http://lorempixel.com/640/480/business", 64f, "ratione" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
