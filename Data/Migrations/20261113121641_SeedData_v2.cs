using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"), new DateOnly(1922, 3, 18), "Politiker", "Egon Bahr" },
                    { new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"), new DateOnly(1828, 9, 9), "Schriftsteller", "Lew Nikolajewitsch Tolstoi" },
                    { new Guid("259de399-f149-4ed9-a456-3208499ccd93"), new DateOnly(1906, 10, 14), "Publizistin", "Hannah Arendt" },
                    { new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), new DateOnly(1854, 10, 16), "Schriftsteller", "Oscar Wilde" },
                    { new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"), new DateOnly(1977, 5, 25), "Jedi-Meister", "Yoda" },
                    { new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), new DateOnly(1835, 11, 30), "Philosoph", "Mark Twain" },
                    { new Guid("595f9fb4-f452-40f9-8a11-576d74a343f8"), new DateOnly(1871, 3, 5), "Politikerin", "Rosa Luxemburg" },
                    { new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"), new DateOnly(1879, 3, 14), "Physiker", "Albert Einstein" },
                    { new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"), new DateOnly(1890, 1, 9), "Journalist", "Kurt Tucholsky" },
                    { new Guid("a5a914ea-de67-4522-86f5-90ff872c9e84"), new DateOnly(1869, 10, 2), "Anwalt", "Mahatma Gandhi" },
                    { new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"), new DateOnly(1946, 4, 12), "Schuhverkäufer", "Al Bundy" },
                    { new Guid("c37b5bc0-19db-497f-968b-0e2d05627c8d"), new DateOnly(1815, 4, 1), "Politiker", "Otto von Bismarck" }
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "AuthorId", "QuoteText" },
                values: new object[,]
                {
                    { new Guid("028d79d4-7b2b-4b17-aaac-ae323e2661cc"), new Guid("c37b5bc0-19db-497f-968b-0e2d05627c8d"), "Wenn man sagt, daß man einer Sache grundsätzlich zustimmt, bedeutet das, daß man nicht die geringste Absicht hat, sie in der Praxis durchzuführen." },
                    { new Guid("04039a5b-34e6-4e41-bd80-7ed09b20f5f9"), new Guid("c37b5bc0-19db-497f-968b-0e2d05627c8d"), "Wenn irgendwo zwischen zwei Mächten ein noch so harmlos aussehender Pakt geschlossen wird, muss man sich sofort fragen, wer hier umgebracht werden soll." },
                    { new Guid("040e2aa1-55b4-48c0-a1ef-d6e837df8f0a"), new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"), "Der Vorteil der Klugheit besteht darin, daß man sich dumm stellen kann. Das Gegenteil ist schon schwieriger." },
                    { new Guid("151d3f36-b603-437d-a624-eacdfc7211ed"), new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"), "Jeder denkt daran, die Welt zu verändern, aber niemand denkt daran, sich selbst zu verändern." },
                    { new Guid("164c2406-8f71-4a29-983e-e2744ee9d79c"), new Guid("c37b5bc0-19db-497f-968b-0e2d05627c8d"), "Das Vertrauen ist eine zarte Pflanze; ist es zerstört, so kommt es sobald nicht wieder." },
                    { new Guid("184df617-2cac-43d3-a05c-20b0649a5e10"), new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), "Gesegnet seien jene, die nichts zu sagen haben und den Mund halten." },
                    { new Guid("19833b2b-829f-4d10-a6ac-511cc4bf26d7"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Seien Sie vorsichtig mit Gesundheitsbüchern - Sie könnten an einem Druckfehler sterben." },
                    { new Guid("1a0a0d69-1d2c-46a1-a7cb-f1e984b72a23"), new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"), "Tue es oder tue es nicht. Es gibt kein Versuchen." },
                    { new Guid("1e368a2d-e98e-4f8e-8b92-b2e2c3738bc1"), new Guid("259de399-f149-4ed9-a456-3208499ccd93"), "Vergebung ist der einzige Weg, um den irreversiblen Fluss der Geschichte umzukehren." },
                    { new Guid("1ed2322a-0077-4afb-b938-4c52f25d336d"), new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"), "Die menschliche Dummheit ist international." },
                    { new Guid("1ed4f7ce-1cac-45f3-b9c3-446e88fe5332"), new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"), "Wenn die Menschen nur über das sprächen, was sie begreifen, dann würde es sehr still auf der Welt sein." },
                    { new Guid("1ef53c20-684c-40d1-9308-34f02b1ad5f0"), new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"), "Streitende sollten wissen, daß nie einer ganz recht hat und der andere ganz unrecht." },
                    { new Guid("2ca1c3fc-9659-4c38-b7bc-ee5a6ac7b73f"), new Guid("595f9fb4-f452-40f9-8a11-576d74a343f8"), "Wer sich nicht bewegt, spürt seine Fesseln nicht!" },
                    { new Guid("3243f17b-aa2a-4cca-b799-4e1f158d435d"), new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"), "Dass die Regierung das Volk vertrete, ist eine Fiktion, eine Lüge." },
                    { new Guid("360d9e39-e955-4df0-b651-591b31adfe99"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Man könnte viele Beispiele für unsinnige Ausgaben nennen, aber keines ist treffender als die Errichtung einer Friedhofsmauer. Die, die drinnen sind, können sowieso nicht hinaus, und die, die draußen sind, wollen nicht hinein." },
                    { new Guid("41083824-2a98-4dc9-bf29-233d72ee0e33"), new Guid("595f9fb4-f452-40f9-8a11-576d74a343f8"), "Die Dividenden steigen und die Proletarier fallen." },
                    { new Guid("43c8d4db-ee56-49aa-b288-aa200a17bd63"), new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"), "Furcht führt zu Wut, Wut führt zu Hass. Hass führt zu unsäglichem Leid." },
                    { new Guid("4b8036b4-ac00-4055-a89c-3981a81d4828"), new Guid("259de399-f149-4ed9-a456-3208499ccd93"), "Gewalt beginnt, wo das Reden aufhört." },
                    { new Guid("51d2a708-a75e-46c4-b3ff-e46fc52e0197"), new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"), "Irgendwo auf dieser Welt muss es doch einen Menschen geben, der weniger verdient als ich!" },
                    { new Guid("5593d709-ea39-4da4-8f1e-04f09e8781de"), new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"), "Ich bin der einzige Typ auf der Welt, der erst aufwachen muss, um einen Alptraum zu haben." },
                    { new Guid("56504a2d-79f0-4cec-bf5c-564dc9b0828b"), new Guid("595f9fb4-f452-40f9-8a11-576d74a343f8"), "Mir imponieren nur die Ratschläge, die der Ratgebende selbst beherzigt." },
                    { new Guid("593102aa-ea18-4d3f-bc60-95c8646716c7"), new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"), "Lieber probieren und schlecht machen, als gar nichts tun." },
                    { new Guid("5fa1b2a1-1db8-476a-ace1-67a6b0bc4684"), new Guid("259de399-f149-4ed9-a456-3208499ccd93"), "Der radikalste Revolutionär wird ein Konservativer am Tag nach der Revolution." },
                    { new Guid("63affda6-c3cd-4f01-988c-b8d78601ff9c"), new Guid("259de399-f149-4ed9-a456-3208499ccd93"), "Die Herrschaft des Niemand, die eigentliche Staatsform der Bürokratie." },
                    { new Guid("63f0e19e-d06f-47cd-88b9-7c5c77a40c26"), new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), "Patriotismus ist die Tugend der Boshaften." },
                    { new Guid("64b91895-5bc6-4447-ab29-40ff62c3dc4c"), new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"), "Viel zu lernen du noch hast." },
                    { new Guid("6610425b-12f8-43a9-b261-9c403c68fd88"), new Guid("a5a914ea-de67-4522-86f5-90ff872c9e84"), "Sklaverei besteht nicht nur aus physischen Ketten, sondern aus dem Zustand des Geistes." },
                    { new Guid("6b515345-f34d-45a8-b3e5-788f759c2ab5"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Gott hat den Menschen erschaffen, weil er vom Affen enttäuscht war. Danach hat er auf weitere Experimente verzichtet." },
                    { new Guid("6c1f2d10-033a-47a8-9a3d-2f0ec935a083"), new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"), "Es gibt zwei Dinge die ein Bundy nicht tut: Wir essen kein Gemüse, und wir klopfen nicht an." },
                    { new Guid("6e04ded5-8fd8-4ba4-a47a-50c33113cd55"), new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"), "Es gibt keine großen Entdeckungen und Fortschritte, solange es noch ein unglückliches Kind auf Erden gibt." },
                    { new Guid("6f9a165d-6739-43b4-bbe9-2f25fb313575"), new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"), "In der internationalen Politik geht es nie um Demokratie oder Menschenrechte. Es geht um die Interessen von Staaten. Merken Sie sich das, egal, was man Ihnen im Geschichtsunterricht erzählt." },
                    { new Guid("711f3ceb-f709-4a0d-b68a-148b4097d849"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Man vergisst vielleicht, wo man die Friedenspfeife vergraben hat. Aber man vergisst niemals, wo das Beil liegt." },
                    { new Guid("7d4e0bf3-d304-4514-bfda-c43af5e3bc10"), new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"), "Verstand ohne Gefühl ist unmenschlich; Gefühl ohne Verstand ist Dummheit." },
                    { new Guid("85221e71-3fca-443a-836a-92cb3da79315"), new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"), "Holzhacken ist deshalb so beliebt, weil man bei dieser Tätigkeit den Erfolg sofort sieht." },
                    { new Guid("885d8061-ea8d-4e45-bdfa-94ea2c5afae0"), new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"), "Eine der besten Energiequellen ist Stolz auf die eigene Leistung." },
                    { new Guid("887cdb21-3199-4348-8015-dc8647732df6"), new Guid("259de399-f149-4ed9-a456-3208499ccd93"), "Es gibt keine gefährlichen Gedanken; Das Denken an sich, ist gefährlich." },
                    { new Guid("8ecaced4-8237-43dd-a104-fec357a94c3c"), new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"), "Phantasie ist wichtiger als Wissen, denn Wissen ist begrenzt." },
                    { new Guid("92447b27-edcd-4c3e-b2e6-5c33d113b4c9"), new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), "Die Ehe ist ein Versuch, zu zweit wenigstens halb so glücklich zu werden, wie man allein gewesen ist." },
                    { new Guid("94f2e522-025c-486c-8569-9c0c91c08140"), new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"), "Wer den Einfluss der Droge Macht bestreitet, der lügt oder verdrängt." },
                    { new Guid("9aa523d1-3954-4bed-bf5d-3fe343c4fabc"), new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"), "Wenn ein Politiker anfängt, über Werte zu schwadronieren, anstatt seine Interessen zu benennen, wird es höchste Zeit, den Raum zu verlassen." },
                    { new Guid("9c928662-8918-4637-a33f-e347b1216106"), new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), "Eigenliebe ist der Beginn einer lebenslangen Romanze." },
                    { new Guid("ac16244a-1514-456f-acee-2849121f1470"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Schade, dass die Weltverbesserer nie bei sich anfangen." },
                    { new Guid("acf5d373-3fc6-4fc4-8f14-8bfea9f36cf7"), new Guid("595f9fb4-f452-40f9-8a11-576d74a343f8"), "Freiheit ist immer die Freiheit des Andersdenkenden." },
                    { new Guid("af0d0921-67e2-479e-b101-fe5af0fd67a5"), new Guid("a5a914ea-de67-4522-86f5-90ff872c9e84"), "Auge um Auge – und die ganze Welt wird blind sein." },
                    { new Guid("b1e25ddb-35d4-40c5-bbd4-bba7a63c84e4"), new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), "Die Ehe ist eine gegenseitige Freiheitsberaubung in beiderseitigem Einvernehmen." },
                    { new Guid("b2680dc6-ff76-463e-9fb9-df3336fe73c0"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Tatsachen muss man kennen, bevor man sie verdrehen kann." },
                    { new Guid("b6605cdf-80f7-4ec4-867c-34359cc33a71"), new Guid("a5a914ea-de67-4522-86f5-90ff872c9e84"), "Der Schwache kann niemals vergeben. Vergebung ist das Attribut des Starken." },
                    { new Guid("c46d7051-7121-4894-a0c5-7557a3e78d0b"), new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"), "Der Satiriker ist ein gekränkter Idealist." },
                    { new Guid("ca379cc2-15de-4452-91dc-48cc4021cbd3"), new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"), "Versicherungen sind wie die Ehe: Du zahlst und zahlst, aber du kriegst nichts zurück." },
                    { new Guid("cf6d1b58-870e-47d4-98dc-f1d682e53b4d"), new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"), "Das Recht auf Dummheit gehört zur Garantie der freien Entfaltung der Persönlichkeit." },
                    { new Guid("d8ecb092-226f-4e07-95ac-25556f310db0"), new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"), "Ein Zyniker ist ein Mensch, der von jedem Ding den Preis und von keinem den Wert kennt." },
                    { new Guid("d91bf90b-0527-4a60-b353-fda65b65edd0"), new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"), "Ich bin nicht sicher, mit welchen Waffen der dritte Weltkrieg ausgetragen wird, aber im vierten Weltkrieg werden sie mit Stöcken und Steinen kämpfen." },
                    { new Guid("f0806451-f71a-424f-9dbd-45756b2d9920"), new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"), "Falsch hört nicht auf, falsch zu sein, weil die Mehrheit daran beteiligt ist." },
                    { new Guid("f100d9ac-c988-407c-bbc9-d9d3ef0d45c5"), new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"), "Ein großer Krieger? Groß machen Kriege niemanden." },
                    { new Guid("f30d8b61-714a-45bf-b4af-130c33aab117"), new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"), "Weihnachten ist nicht die Zeit zum Bereuen. Dafür sind Hochzeitstage da." },
                    { new Guid("f535bf49-a8ca-470c-b94e-25702591adb4"), new Guid("a5a914ea-de67-4522-86f5-90ff872c9e84"), "Sei du selbst die Veränderung, die du dir wünschst für diese Welt." },
                    { new Guid("f9ca7342-0e9d-416a-8b76-d804231c4015"), new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"), "Dürfen darf man alles, man muss es nur können." },
                    { new Guid("fbc8ca47-9d1d-4212-98a0-ac53820ba874"), new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"), "Wenn so mächtig ihr seid, warum dann schon gehen?" },
                    { new Guid("fd010b5a-4735-4cb3-aef0-ac75bf15c499"), new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"), "Solange es Schlachthäuser gibt, wird es auch Schlachtfelder geben." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("028d79d4-7b2b-4b17-aaac-ae323e2661cc"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("04039a5b-34e6-4e41-bd80-7ed09b20f5f9"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("040e2aa1-55b4-48c0-a1ef-d6e837df8f0a"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("151d3f36-b603-437d-a624-eacdfc7211ed"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("164c2406-8f71-4a29-983e-e2744ee9d79c"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("184df617-2cac-43d3-a05c-20b0649a5e10"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("19833b2b-829f-4d10-a6ac-511cc4bf26d7"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("1a0a0d69-1d2c-46a1-a7cb-f1e984b72a23"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("1e368a2d-e98e-4f8e-8b92-b2e2c3738bc1"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("1ed2322a-0077-4afb-b938-4c52f25d336d"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("1ed4f7ce-1cac-45f3-b9c3-446e88fe5332"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("1ef53c20-684c-40d1-9308-34f02b1ad5f0"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("2ca1c3fc-9659-4c38-b7bc-ee5a6ac7b73f"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("3243f17b-aa2a-4cca-b799-4e1f158d435d"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("360d9e39-e955-4df0-b651-591b31adfe99"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("41083824-2a98-4dc9-bf29-233d72ee0e33"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("43c8d4db-ee56-49aa-b288-aa200a17bd63"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("4b8036b4-ac00-4055-a89c-3981a81d4828"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("51d2a708-a75e-46c4-b3ff-e46fc52e0197"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("5593d709-ea39-4da4-8f1e-04f09e8781de"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("56504a2d-79f0-4cec-bf5c-564dc9b0828b"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("593102aa-ea18-4d3f-bc60-95c8646716c7"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("5fa1b2a1-1db8-476a-ace1-67a6b0bc4684"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("63affda6-c3cd-4f01-988c-b8d78601ff9c"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("63f0e19e-d06f-47cd-88b9-7c5c77a40c26"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("64b91895-5bc6-4447-ab29-40ff62c3dc4c"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6610425b-12f8-43a9-b261-9c403c68fd88"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6b515345-f34d-45a8-b3e5-788f759c2ab5"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6c1f2d10-033a-47a8-9a3d-2f0ec935a083"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6e04ded5-8fd8-4ba4-a47a-50c33113cd55"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("6f9a165d-6739-43b4-bbe9-2f25fb313575"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("711f3ceb-f709-4a0d-b68a-148b4097d849"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("7d4e0bf3-d304-4514-bfda-c43af5e3bc10"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("85221e71-3fca-443a-836a-92cb3da79315"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("885d8061-ea8d-4e45-bdfa-94ea2c5afae0"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("887cdb21-3199-4348-8015-dc8647732df6"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("8ecaced4-8237-43dd-a104-fec357a94c3c"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("92447b27-edcd-4c3e-b2e6-5c33d113b4c9"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("94f2e522-025c-486c-8569-9c0c91c08140"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("9aa523d1-3954-4bed-bf5d-3fe343c4fabc"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("9c928662-8918-4637-a33f-e347b1216106"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("ac16244a-1514-456f-acee-2849121f1470"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("acf5d373-3fc6-4fc4-8f14-8bfea9f36cf7"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("af0d0921-67e2-479e-b101-fe5af0fd67a5"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("b1e25ddb-35d4-40c5-bbd4-bba7a63c84e4"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("b2680dc6-ff76-463e-9fb9-df3336fe73c0"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("b6605cdf-80f7-4ec4-867c-34359cc33a71"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("c46d7051-7121-4894-a0c5-7557a3e78d0b"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("ca379cc2-15de-4452-91dc-48cc4021cbd3"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("cf6d1b58-870e-47d4-98dc-f1d682e53b4d"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("d8ecb092-226f-4e07-95ac-25556f310db0"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("d91bf90b-0527-4a60-b353-fda65b65edd0"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f0806451-f71a-424f-9dbd-45756b2d9920"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f100d9ac-c988-407c-bbc9-d9d3ef0d45c5"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f30d8b61-714a-45bf-b4af-130c33aab117"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f535bf49-a8ca-470c-b94e-25702591adb4"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("f9ca7342-0e9d-416a-8b76-d804231c4015"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("fbc8ca47-9d1d-4212-98a0-ac53820ba874"));

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: new Guid("fd010b5a-4735-4cb3-aef0-ac75bf15c499"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0129f13b-6ee8-4339-94cd-ad22f472eb8e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1b537fa7-3810-435c-8290-be9e5b5143ad"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("259de399-f149-4ed9-a456-3208499ccd93"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2ebd31ba-fe9e-4c07-b393-3152fa40ada3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("40792abe-b3bd-44db-acc1-790eee1634c7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("595f9fb4-f452-40f9-8a11-576d74a343f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("78c83367-25de-4780-8a35-0c5636d3ca50"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("795ca27e-a7f2-41e5-ad97-71174e99e00d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("a5a914ea-de67-4522-86f5-90ff872c9e84"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b91c2141-9353-45eb-ae5d-3eb7a79f477d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c37b5bc0-19db-497f-968b-0e2d05627c8d"));
        }
    }
}
