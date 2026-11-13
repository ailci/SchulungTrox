using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data;

internal static class ModelBuilderExtensions
{
    internal static void SeedData(this ModelBuilder modelBuilder)
    {
        var einsteinId = Guid.Parse("78c83367-25de-4780-8a35-0c5636d3ca50");
        var twainId = Guid.Parse("4577dc8b-9648-4b9e-a4c7-3fd2dbf9e6cc");
        var wildeId = Guid.Parse("2ebd31ba-fe9e-4c07-b393-3152fa40ada3");
        var tucholskyId = Guid.Parse("795ca27e-a7f2-41e5-ad97-71174e99e00d");
        var bismarckId = Guid.Parse("c37b5bc0-19db-497f-968b-0e2d05627c8d");
        var bahrId = Guid.Parse("0129f13b-6ee8-4339-94cd-ad22f472eb8e");
        var luxemburgId = Guid.Parse("595f9fb4-f452-40f9-8a11-576d74a343f8");
        var gandhiId = Guid.Parse("a5a914ea-de67-4522-86f5-90ff872c9e84");
        var tolstoiId = Guid.Parse("1b537fa7-3810-435c-8290-be9e5b5143ad");
        var yodaId = Guid.Parse("40792abe-b3bd-44db-acc1-790eee1634c7");
        var arendtId = Guid.Parse("259de399-f149-4ed9-a456-3208499ccd93");
        var bundyId = Guid.Parse("b91c2141-9353-45eb-ae5d-3eb7a79f477d");


        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                Id = einsteinId,
                Name = "Albert Einstein",
                Description = "Physiker",
                BirthDate = new DateOnly(1879, 03, 14),
            },
            new Author
            {
                Id = twainId,
                Name = "Mark Twain",
                Description = "Philosoph",
                BirthDate = new DateOnly(1835, 11, 30),
            },
            new Author
            {
                Id = wildeId,
                Name = "Oscar Wilde",
                Description = "Schriftsteller",
                BirthDate = new DateOnly(1854, 10, 16),
            },
            new Author
            {
                Id = tucholskyId,
                Name = "Kurt Tucholsky",
                Description = "Journalist",
                BirthDate = new DateOnly(1890, 01, 09),
            },
            new Author
            {
                Id = bismarckId,
                Name = "Otto von Bismarck",
                Description = "Politiker",
                BirthDate = new DateOnly(1815, 04, 01),
            },
            new Author
            {
                Id = bahrId,
                Name = "Egon Bahr",
                Description = "Politiker",
                BirthDate = new DateOnly(1922, 03, 18),
            },
            new Author
            {
                Id = luxemburgId,
                Name = "Rosa Luxemburg",
                Description = "Politikerin",
                BirthDate = new DateOnly(1871, 03, 05),
            },
            new Author
            {
                Id = gandhiId,
                Name = "Mahatma Gandhi",
                Description = "Anwalt",
                BirthDate = new DateOnly(1869, 10, 02),
            },
            new Author
            {
                Id = tolstoiId,
                Name = "Lew Nikolajewitsch Tolstoi",
                Description = "Schriftsteller",
                BirthDate = new DateOnly(1828, 09, 09),
            },
            new Author
            {
                Id = yodaId,
                Name = "Yoda",
                Description = "Jedi-Meister",
                BirthDate = new DateOnly(1977, 05, 25),
            },
            new Author
            {
                Id = arendtId,
                Name = "Hannah Arendt",
                Description = "Publizistin",
                BirthDate = new DateOnly(1906, 10, 14),
            },
            new Author
            {
                Id = bundyId,
                Name = "Al Bundy",
                Description = "Schuhverkäufer",
                BirthDate = new DateOnly(1946, 04, 12),
            });

        modelBuilder.Entity<Quote>().HasData(
           new Quote
           {
               Id = Guid.Parse("d91bf90b-0527-4a60-b353-fda65b65edd0"),
               AuthorId = einsteinId,
               QuoteText = "Ich bin nicht sicher, mit welchen Waffen der dritte Weltkrieg ausgetragen wird, aber im vierten Weltkrieg werden sie mit Stöcken und Steinen kämpfen."
           },
           new Quote
           {
               Id = Guid.Parse("8ecaced4-8237-43dd-a104-fec357a94c3c"),
               AuthorId = einsteinId,
               QuoteText = "Phantasie ist wichtiger als Wissen, denn Wissen ist begrenzt."
           },
           new Quote
           {
               Id = Guid.Parse("6e04ded5-8fd8-4ba4-a47a-50c33113cd55"),
               AuthorId = einsteinId,
               QuoteText = "Es gibt keine großen Entdeckungen und Fortschritte, solange es noch ein unglückliches Kind auf Erden gibt."
           },
           new Quote
           {
               Id = Guid.Parse("85221e71-3fca-443a-836a-92cb3da79315"),
               AuthorId = einsteinId,
               QuoteText = "Holzhacken ist deshalb so beliebt, weil man bei dieser Tätigkeit den Erfolg sofort sieht."
           },
           new Quote
           {
               Id = Guid.Parse("1ed4f7ce-1cac-45f3-b9c3-446e88fe5332"),
               AuthorId = einsteinId,
               QuoteText = "Wenn die Menschen nur über das sprächen, was sie begreifen, dann würde es sehr still auf der Welt sein."
           },
           new Quote
           {
               Id = Guid.Parse("6b515345-f34d-45a8-b3e5-788f759c2ab5"),
               AuthorId = twainId,
               QuoteText = "Gott hat den Menschen erschaffen, weil er vom Affen enttäuscht war. Danach hat er auf weitere Experimente verzichtet."
           },
           new Quote
           {
               Id = Guid.Parse("360d9e39-e955-4df0-b651-591b31adfe99"),
               AuthorId = twainId,
               QuoteText = "Man könnte viele Beispiele für unsinnige Ausgaben nennen, aber keines ist treffender als die Errichtung einer Friedhofsmauer. Die, die drinnen sind, können sowieso nicht hinaus, und die, die draußen sind, wollen nicht hinein."
           },
           new Quote
           {
               Id = Guid.Parse("711f3ceb-f709-4a0d-b68a-148b4097d849"),
               AuthorId = twainId,
               QuoteText = "Man vergisst vielleicht, wo man die Friedenspfeife vergraben hat. Aber man vergisst niemals, wo das Beil liegt."
           },
           new Quote
           {
               Id = Guid.Parse("ac16244a-1514-456f-acee-2849121f1470"),
               AuthorId = twainId,
               QuoteText = "Schade, dass die Weltverbesserer nie bei sich anfangen."
           },
           new Quote
           {
               Id = Guid.Parse("b2680dc6-ff76-463e-9fb9-df3336fe73c0"),
               AuthorId = twainId,
               QuoteText = "Tatsachen muss man kennen, bevor man sie verdrehen kann."
           },
           new Quote
           {
               Id = Guid.Parse("cf6d1b58-870e-47d4-98dc-f1d682e53b4d"),
               AuthorId = twainId,
               QuoteText = "Das Recht auf Dummheit gehört zur Garantie der freien Entfaltung der Persönlichkeit."
           },
           new Quote
           {
               Id = Guid.Parse("19833b2b-829f-4d10-a6ac-511cc4bf26d7"),
               AuthorId = twainId,
               QuoteText = "Seien Sie vorsichtig mit Gesundheitsbüchern - Sie könnten an einem Druckfehler sterben."
           },
           new Quote
           {
               Id = Guid.Parse("184df617-2cac-43d3-a05c-20b0649a5e10"),
               AuthorId = wildeId,
               QuoteText = "Gesegnet seien jene, die nichts zu sagen haben und den Mund halten."
           },
           new Quote
           {
               Id = Guid.Parse("63f0e19e-d06f-47cd-88b9-7c5c77a40c26"),
               AuthorId = wildeId,
               QuoteText = "Patriotismus ist die Tugend der Boshaften."
           },
           new Quote
           {
               Id = Guid.Parse("9c928662-8918-4637-a33f-e347b1216106"),
               AuthorId = wildeId,
               QuoteText = "Eigenliebe ist der Beginn einer lebenslangen Romanze."
           },
           new Quote
           {
               Id = Guid.Parse("b1e25ddb-35d4-40c5-bbd4-bba7a63c84e4"),
               AuthorId = wildeId,
               QuoteText = "Die Ehe ist eine gegenseitige Freiheitsberaubung in beiderseitigem Einvernehmen."
           },
           new Quote
           {
               Id = Guid.Parse("d8ecb092-226f-4e07-95ac-25556f310db0"),
               AuthorId = wildeId,
               QuoteText = "Ein Zyniker ist ein Mensch, der von jedem Ding den Preis und von keinem den Wert kennt."
           },
           new Quote
           {
               Id = Guid.Parse("92447b27-edcd-4c3e-b2e6-5c33d113b4c9"),
               AuthorId = wildeId,
               QuoteText = "Die Ehe ist ein Versuch, zu zweit wenigstens halb so glücklich zu werden, wie man allein gewesen ist."
           },
           new Quote
           {
               Id = Guid.Parse("1ef53c20-684c-40d1-9308-34f02b1ad5f0"),
               AuthorId = tucholskyId,
               QuoteText = "Streitende sollten wissen, daß nie einer ganz recht hat und der andere ganz unrecht."
           },
           new Quote
           {
               Id = Guid.Parse("040e2aa1-55b4-48c0-a1ef-d6e837df8f0a"),
               AuthorId = tucholskyId,
               QuoteText = "Der Vorteil der Klugheit besteht darin, daß man sich dumm stellen kann. Das Gegenteil ist schon schwieriger."
           },
           new Quote
           {
               Id = Guid.Parse("c46d7051-7121-4894-a0c5-7557a3e78d0b"),
               AuthorId = tucholskyId,
               QuoteText = "Der Satiriker ist ein gekränkter Idealist."
           },
           new Quote
           {
               Id = Guid.Parse("1ed2322a-0077-4afb-b938-4c52f25d336d"),
               AuthorId = tucholskyId,
               QuoteText = "Die menschliche Dummheit ist international."
           },
           new Quote
           {
               Id = Guid.Parse("f9ca7342-0e9d-416a-8b76-d804231c4015"),
               AuthorId = tucholskyId,
               QuoteText = "Dürfen darf man alles, man muss es nur können."
           },
           new Quote
           {
               Id = Guid.Parse("028d79d4-7b2b-4b17-aaac-ae323e2661cc"),
               AuthorId = bismarckId,
               QuoteText = "Wenn man sagt, daß man einer Sache grundsätzlich zustimmt, bedeutet das, daß man nicht die geringste Absicht hat, sie in der Praxis durchzuführen."
           },
           new Quote
           {
               Id = Guid.Parse("164c2406-8f71-4a29-983e-e2744ee9d79c"),
               AuthorId = bismarckId,
               QuoteText = "Das Vertrauen ist eine zarte Pflanze; ist es zerstört, so kommt es sobald nicht wieder."
           },
           new Quote
           {
               Id = Guid.Parse("04039a5b-34e6-4e41-bd80-7ed09b20f5f9"),
               AuthorId = bismarckId,
               QuoteText = "Wenn irgendwo zwischen zwei Mächten ein noch so harmlos aussehender Pakt geschlossen wird, muss man sich sofort fragen, wer hier umgebracht werden soll."
           },
           new Quote
           {
               Id = Guid.Parse("7d4e0bf3-d304-4514-bfda-c43af5e3bc10"),
               AuthorId = bahrId,
               QuoteText = "Verstand ohne Gefühl ist unmenschlich; Gefühl ohne Verstand ist Dummheit."
           },
           new Quote
           {
               Id = Guid.Parse("94f2e522-025c-486c-8569-9c0c91c08140"),
               AuthorId = bahrId,
               QuoteText = "Wer den Einfluss der Droge Macht bestreitet, der lügt oder verdrängt."
           },
           new Quote
           {
               Id = Guid.Parse("6f9a165d-6739-43b4-bbe9-2f25fb313575"),
               AuthorId = bahrId,
               QuoteText = "In der internationalen Politik geht es nie um Demokratie oder Menschenrechte. Es geht um die Interessen von Staaten. Merken Sie sich das, egal, was man Ihnen im Geschichtsunterricht erzählt."
           },
           new Quote
           {
               Id = Guid.Parse("9aa523d1-3954-4bed-bf5d-3fe343c4fabc"),
               AuthorId = bahrId,
               QuoteText = "Wenn ein Politiker anfängt, über Werte zu schwadronieren, anstatt seine Interessen zu benennen, wird es höchste Zeit, den Raum zu verlassen."
           },
           new Quote
           {
               Id = Guid.Parse("885d8061-ea8d-4e45-bdfa-94ea2c5afae0"),
               AuthorId = bahrId,
               QuoteText = "Eine der besten Energiequellen ist Stolz auf die eigene Leistung."
           },
           new Quote
           {
               Id = Guid.Parse("acf5d373-3fc6-4fc4-8f14-8bfea9f36cf7"),
               AuthorId = luxemburgId,
               QuoteText = "Freiheit ist immer die Freiheit des Andersdenkenden."
           },
           new Quote
           {
               Id = Guid.Parse("56504a2d-79f0-4cec-bf5c-564dc9b0828b"),
               AuthorId = luxemburgId,
               QuoteText = "Mir imponieren nur die Ratschläge, die der Ratgebende selbst beherzigt."
           },
           new Quote
           {
               Id = Guid.Parse("2ca1c3fc-9659-4c38-b7bc-ee5a6ac7b73f"),
               AuthorId = luxemburgId,
               QuoteText = "Wer sich nicht bewegt, spürt seine Fesseln nicht!"
           },
           new Quote
           {
               Id = Guid.Parse("41083824-2a98-4dc9-bf29-233d72ee0e33"),
               AuthorId = luxemburgId,
               QuoteText = "Die Dividenden steigen und die Proletarier fallen."
           },
           new Quote
           {
               Id = Guid.Parse("f535bf49-a8ca-470c-b94e-25702591adb4"),
               AuthorId = gandhiId,
               QuoteText = "Sei du selbst die Veränderung, die du dir wünschst für diese Welt."
           },
           new Quote
           {
               Id = Guid.Parse("af0d0921-67e2-479e-b101-fe5af0fd67a5"),
               AuthorId = gandhiId,
               QuoteText = "Auge um Auge – und die ganze Welt wird blind sein."
           },
           new Quote
           {
               Id = Guid.Parse("b6605cdf-80f7-4ec4-867c-34359cc33a71"),
               AuthorId = gandhiId,
               QuoteText = "Der Schwache kann niemals vergeben. Vergebung ist das Attribut des Starken."
           },
           new Quote
           {
               Id = Guid.Parse("6610425b-12f8-43a9-b261-9c403c68fd88"),
               AuthorId = gandhiId,
               QuoteText = "Sklaverei besteht nicht nur aus physischen Ketten, sondern aus dem Zustand des Geistes."
           },
           new Quote
           {
               Id = Guid.Parse("151d3f36-b603-437d-a624-eacdfc7211ed"),
               AuthorId = tolstoiId,
               QuoteText = "Jeder denkt daran, die Welt zu verändern, aber niemand denkt daran, sich selbst zu verändern."
           },
           new Quote
           {
               Id = Guid.Parse("f0806451-f71a-424f-9dbd-45756b2d9920"),
               AuthorId = tolstoiId,
               QuoteText = "Falsch hört nicht auf, falsch zu sein, weil die Mehrheit daran beteiligt ist."
           },
           new Quote
           {
               Id = Guid.Parse("593102aa-ea18-4d3f-bc60-95c8646716c7"),
               AuthorId = tolstoiId,
               QuoteText = "Lieber probieren und schlecht machen, als gar nichts tun."
           },
           new Quote
           {
               Id = Guid.Parse("3243f17b-aa2a-4cca-b799-4e1f158d435d"),
               AuthorId = tolstoiId,
               QuoteText = "Dass die Regierung das Volk vertrete, ist eine Fiktion, eine Lüge."
           },
           new Quote
           {
               Id = Guid.Parse("fd010b5a-4735-4cb3-aef0-ac75bf15c499"),
               AuthorId = tolstoiId,
               QuoteText = "Solange es Schlachthäuser gibt, wird es auch Schlachtfelder geben."
           },
           new Quote
           {
               Id = Guid.Parse("64b91895-5bc6-4447-ab29-40ff62c3dc4c"),
               AuthorId = yodaId,
               QuoteText = "Viel zu lernen du noch hast."
           },
           new Quote
           {
               Id = Guid.Parse("1a0a0d69-1d2c-46a1-a7cb-f1e984b72a23"),
               AuthorId = yodaId,
               QuoteText = "Tue es oder tue es nicht. Es gibt kein Versuchen."
           },
           new Quote
           {
               Id = Guid.Parse("43c8d4db-ee56-49aa-b288-aa200a17bd63"),
               AuthorId = yodaId,
               QuoteText = "Furcht führt zu Wut, Wut führt zu Hass. Hass führt zu unsäglichem Leid."
           },
           new Quote
           {
               Id = Guid.Parse("fbc8ca47-9d1d-4212-98a0-ac53820ba874"),
               AuthorId = yodaId,
               QuoteText = "Wenn so mächtig ihr seid, warum dann schon gehen?"
           },
           new Quote
           {
               Id = Guid.Parse("f100d9ac-c988-407c-bbc9-d9d3ef0d45c5"),
               AuthorId = yodaId,
               QuoteText = "Ein großer Krieger? Groß machen Kriege niemanden."
           },
           new Quote
           {
               Id = Guid.Parse("887cdb21-3199-4348-8015-dc8647732df6"),
               AuthorId = arendtId,
               QuoteText = "Es gibt keine gefährlichen Gedanken; Das Denken an sich, ist gefährlich."
           },
           new Quote
           {
               Id = Guid.Parse("1e368a2d-e98e-4f8e-8b92-b2e2c3738bc1"),
               AuthorId = arendtId,
               QuoteText = "Vergebung ist der einzige Weg, um den irreversiblen Fluss der Geschichte umzukehren."
           },
           new Quote
           {
               Id = Guid.Parse("4b8036b4-ac00-4055-a89c-3981a81d4828"),
               AuthorId = arendtId,
               QuoteText = "Gewalt beginnt, wo das Reden aufhört."
           },
           new Quote
           {
               Id = Guid.Parse("63affda6-c3cd-4f01-988c-b8d78601ff9c"),
               AuthorId = arendtId,
               QuoteText = "Die Herrschaft des Niemand, die eigentliche Staatsform der Bürokratie."
           },
           new Quote
           {
               Id = Guid.Parse("5fa1b2a1-1db8-476a-ace1-67a6b0bc4684"),
               AuthorId = arendtId,
               QuoteText = "Der radikalste Revolutionär wird ein Konservativer am Tag nach der Revolution."
           },
           new Quote
           {
               Id = Guid.Parse("ca379cc2-15de-4452-91dc-48cc4021cbd3"),
               AuthorId = bundyId,
               QuoteText = "Versicherungen sind wie die Ehe: Du zahlst und zahlst, aber du kriegst nichts zurück."
           },
           new Quote
           {
               Id = Guid.Parse("51d2a708-a75e-46c4-b3ff-e46fc52e0197"),
               AuthorId = bundyId,
               QuoteText = "Irgendwo auf dieser Welt muss es doch einen Menschen geben, der weniger verdient als ich!"
           },
           new Quote
           {
               Id = Guid.Parse("5593d709-ea39-4da4-8f1e-04f09e8781de"),
               AuthorId = bundyId,
               QuoteText = "Ich bin der einzige Typ auf der Welt, der erst aufwachen muss, um einen Alptraum zu haben."
           },
           new Quote
           {
               Id = Guid.Parse("f30d8b61-714a-45bf-b4af-130c33aab117"),
               AuthorId = bundyId,
               QuoteText = "Weihnachten ist nicht die Zeit zum Bereuen. Dafür sind Hochzeitstage da."
           },
           new Quote
           {
               Id = Guid.Parse("6c1f2d10-033a-47a8-9a3d-2f0ec935a083"),
               AuthorId = bundyId,
               QuoteText = "Es gibt zwei Dinge die ein Bundy nicht tut: Wir essen kein Gemüse, und wir klopfen nicht an."
           });
    }
}