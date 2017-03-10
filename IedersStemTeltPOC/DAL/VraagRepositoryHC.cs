using IST.BL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST.DAL
{
    class VraagRepositoryHC : IVraagRepository
    {
        private List<Thema> themas;
        private List<Vraag> vragen;
        private List<Antwoord> antwoorden;
        private List<Resultaat> resultaten;
        private List<Eigenschap> eigenschappen;
        private List<Voorwaarde> voorwaarden;

        public VraagRepositoryHC()
        {
            Seed();
        }

        private void Seed()
        {

            themas = new List<Thema>();
            vragen = new List<Vraag>();
            antwoorden = new List<Antwoord>();
            resultaten = new List<Resultaat>();
            eigenschappen = new List<Eigenschap>();
            voorwaarden = new List<Voorwaarde>();

            //thema: Persona
            Thema t1 = new Thema()
            {
                ThemaId = themas.Count + 1,
                ThemaNaam = "Persona",
                ThemaTekst = "Vragen rond de persoonsgebonden eigenschappen. Wil je als vrouw of man de vragen oplossen? Wil je een scenario waar je kinderen hebt of liever niet?",
                Standpunten = new List<PartijStandpunt>(),
                Vragen = new List<Vraag>(),
                ThemaImageUrl = "someThemaImgeUrl"
            };
            themas.Add(t1);

            //Persona: Vraag met 2 antwoorden
            Vraag t1v1 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<VraagVoorwaarde>(),
                VraagTekst = "Heb je kinderen of niet?",
                VraagKernTekst = "Kinderen?",
                Thema = t1,
                VraagImageUrl = "someVraagImgUrl"
            };
            t1.Vragen.Add(t1v1);
            vragen.Add(t1v1);

            Antwoord t1v1a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "Kinderen",
                AntwoordTekst = "ik leg de keuzetest af als iemand met kinderen",
                Vraag = t1v1
            };
            t1v1.Antwoorden.Add(t1v1a1);
            antwoorden.Add(t1v1a1);

            Antwoord t1v1a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "Geen Kinderen",
                AntwoordTekst = "ik leg de keuzetest af als iemand zonder kinderen",
                Vraag = t1v1
            };
            t1v1.Antwoorden.Add(t1v1a2);
            antwoorden.Add(t1v1a2);

            //Persona: Vraag met 2 antwoorden
            Vraag t1v2 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<VraagVoorwaarde>(),
                VraagTekst = "Hebben je ouders of grootouders een andere nationaliteit dan de belgische?",
                VraagKernTekst = "afkomst?",
                Thema = t1,
                VraagImageUrl = "someVraagImgUrl"
            };
            t1.Vragen.Add(t1v2);
            vragen.Add(t1v2);

            Antwoord t1v2a1 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "belgisch",
                AntwoordTekst = "ik leg de keuzetest af als iemand met volledig belgische achtergrond",
                Vraag = t1v2
            };
            t1v2.Antwoorden.Add(t1v2a1);
            antwoorden.Add(t1v2a1);

            Antwoord t1v2a2 = new Antwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "andere",
                AntwoordTekst = "ik leg de keuzetest af als iemand met migratieachtergrond",
                Vraag = t1v2
            };
            t1v2.Antwoorden.Add(t1v2a2);
            antwoorden.Add(t1v2a2);

            //Eigenschappen
            Eigenschap e1 = new Eigenschap()
            {
                EigenschapId = eigenschappen.Count + 1,
                EigenschapNaam = "afkomst",
                Mogelijkheden = new List<string>() { "belgisch", "migratie" },
                Voorwaarden = new List<Voorwaarde>()
            };
            eigenschappen.Add(e1);

            Eigenschap e2 = new Eigenschap() {
                EigenschapId = eigenschappen.Count + 1,
                EigenschapNaam = "gezinssituatie",
                Mogelijkheden = new List<string>() { "kinderen", "geen kinderen" },
                Voorwaarden = new List<Voorwaarde>()
            };

            //thema : Werk
            Thema t2 = new Thema()
            {
                ThemaId = themas.Count + 1,
                ThemaNaam = "Werk",
                ThemaTekst = "Je krijgt vragen over werk",
                Standpunten = new List<PartijStandpunt>(),
                Vragen = new List<Vraag>(),
                ThemaImageUrl = "someThemaImgUrl"
            };
            themas.Add(t2);

            //Werk: Vraag met 2 KeuzeAntwoorden
            Vraag t2v1 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<VraagVoorwaarde>(),
                VraagTekst = "Je krijgt een werkloosheidsuikering en je jonge kinderen zijn thuis. Ga je op zoek naar kinderopvang voor je kinderen en zoek je een baan of wacht je tot ze wat groter zijn ? ",
                VraagKernTekst = "kinderopvang?",
                Thema = t2,
                VraagImageUrl = "someVraagImgUrl"
            };
            t2.Vragen.Add(t2v1);
            vragen.Add(t2v1);

            VraagVoorwaarde t2v1vw1 = new VraagVoorwaarde()
            {
                VoorwaardeId = voorwaarden.Count + 1,
                Eigenschap = e2,
                Vraag = t2v1,
                Waarde = "kinderen"
            };
            voorwaarden.Add(t2v1vw1);
            e2.Voorwaarden.Add(t2v1vw1);
            t2v1.Voorwaarden.Add(t2v1vw1);


            KeuzeAntwoord t2v1a1 = new KeuzeAntwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "kinderopvang",
                AntwoordTekst = "IK ZOEK EEN CRECHE EN WERK",
                Vraag = t2v1,
                Nadelen = "Kinderopvang kost veel geld, kinderen moeten lange dagen maken bij kinderopvang",
                Voordelen = "Je kan concentreren op zoektocht werk. Kinderen hebben contact met anderen",
                Resultaten = new List<Resultaat>()
            };
            t2v1.Antwoorden.Add(t2v1a1);
            antwoorden.Add(t2v1a1);

            KeuzeAntwoord t2v1a2 = new KeuzeAntwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "geen kinderopvang",
                AntwoordTekst = "IK WACHT TOT DE KINDEREN GROTER ZIJN VOOR IK WERK ZOEK",
                Vraag = t2v1,
                Nadelen = "Je hebt minder geld, geen werk",
                Voordelen = "Je ziet je kinderen meer. Kinderen kunnen veilig groot worden",
                Resultaten = new List<Resultaat>()
            };
            t2v1.Antwoorden.Add(t2v1a2);
            antwoorden.Add(t2v1a2);

            
            //Werk: Vraag met 2 KeuzeAntwoorden
            Vraag t2v2 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<VraagVoorwaarde>(),
                VraagTekst = "Je hebt een stage gedaan via de VDAB in een restaurant in de keuken. Je krijgt een tijdelijk contract aangeboden aan het minimumloon.",
                VraagKernTekst = "werken aan minimumloon?",
                Thema = t2,
                VraagImageUrl = "someVraagImgUrl"
            };
            t2.Vragen.Add(t2v2);
            vragen.Add(t2v2);

            VraagVoorwaarde t2v2vw1 = new VraagVoorwaarde()
            {
                VoorwaardeId = voorwaarden.Count + 1,
                Eigenschap = e2,
                Vraag = t2v2,
                Waarde = "geen kinderen"
            };
            voorwaarden.Add(t2v2vw1);
            e2.Voorwaarden.Add(t2v2vw1);
            t2v2.Voorwaarden.Add(t2v2vw1);

            VraagVoorwaarde t2v2vw2 = new VraagVoorwaarde()
            {
                VoorwaardeId = voorwaarden.Count + 1,
                Eigenschap = e1,
                Vraag = t2v2,
                Waarde = "belgisch"
            };
            voorwaarden.Add(t2v2vw2);
            e1.Voorwaarden.Add(t2v2vw2);
            t2v2.Voorwaarden.Add(t2v2vw2);

            KeuzeAntwoord t2v2a1 = new KeuzeAntwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "aannemen",
                AntwoordTekst = "IK NEEM HET CONTRACT AAN",
                Vraag = t2v2,
                Nadelen = "Grote kosten maken: je moet een auto kopen, nieuwe kleren. Het is zwaar werk, je vreest voor je gezondheid",
                Voordelen = "Je doet ervaring op. Je budget is iets hoger.Je leert meer mensen kennen.",
                Resultaten = new List<Resultaat>()
            };
            t2v2.Antwoorden.Add(t2v2a1);
            antwoorden.Add(t2v2a1);

            Resultaat t2v2a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a1,
                Kans = 70,
                ResultaatTekst = "Je hebt het contract aangenomen en je hebt een job. Het zijn lange dagen, maar je bent tevreden dat je ervaring opbouwt.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<ResultaatVoorwaarde>()
            };
            t2v2a1.Resultaten.Add(t2v2a1r1);
            resultaten.Add(t2v2a1r1);

            Resultaat t2v2a1r2 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a1,
                Kans = 20,
                ResultaatTekst = "Je hebt het contract aangenomen, wanneer de subsidies stoppen wordt je onmiddellijk ontslagen.Je hebt geen job.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<ResultaatVoorwaarde>()
            };
            t2v2a1.Resultaten.Add(t2v2a1r2);
            resultaten.Add(t2v2a1r2);

            Resultaat t2v2a1r3 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v2a1,
                Kans = 10,
                ResultaatTekst = "Je hebt het contract aangenomen. Je koopt een wagen met je spaargeld, maar wordt opgelicht.Je geraakt niet op je werk en hebt hoge schulden.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<ResultaatVoorwaarde>()
            };
            t2v2a1.Resultaten.Add(t2v2a1r3);
            resultaten.Add(t2v2a1r3);

            KeuzeAntwoord t2v2a2 = new KeuzeAntwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "niet aannemen",
                AntwoordTekst = "IK WACHT OP EEN INTERESSANTER AANBOD",
                Vraag = t2v2,
                Nadelen = "Werkloosheidsuitkering zakt verder na een tijdje. Eenzaamheid",
                Voordelen = "Je beschikt over je eigen tijd. Je moet geen extra investeringen doen",
                Resultaten = new List<Resultaat>()
            };
            t2v2.Antwoorden.Add(t2v2a2);
            antwoorden.Add(t2v2a2);

            //Werk: Vraag met 2 KeuzeAntwoorden
            Vraag t2v3 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<VraagVoorwaarde>(),
                VraagTekst = "Je hebt een stage gedaan via de VDAB in een restaurant in de keuken. Je krijgt een tijdelijk contract aangeboden aan het minimumloon. Je moet wel je hoofddoek afzetten tijdens het werk.",
                VraagKernTekst = "werken aan minimumloon?",
                Thema = t2,
                VraagImageUrl = "someVraagImgUrl"
            };
            t2.Vragen.Add(t2v3);
            vragen.Add(t2v3);

            VraagVoorwaarde t2v3vw1 = new VraagVoorwaarde()
            {
                VoorwaardeId = voorwaarden.Count + 1,
                Eigenschap = e2,
                Vraag = t2v3,
                Waarde = "geen kinderen"
            };
            voorwaarden.Add(t2v3vw1);
            e2.Voorwaarden.Add(t2v3vw1);
            t2v3.Voorwaarden.Add(t2v3vw1);

            VraagVoorwaarde t2v3vw2 = new VraagVoorwaarde()
            {
                VoorwaardeId = voorwaarden.Count + 1,
                Eigenschap = e1,
                Vraag = t2v3,
                Waarde = "migratie"
            };
            voorwaarden.Add(t2v3vw2);
            e1.Voorwaarden.Add(t2v3vw2);
            t2v3.Voorwaarden.Add(t2v3vw2);

            KeuzeAntwoord t2v3a1 = new KeuzeAntwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "aannemen",
                AntwoordTekst = "IK NEEM HET CONTRACT AAN",
                Vraag = t2v3,
                Nadelen = "Grote kosten maken: je moet een auto kopen, nieuwe kleren. Het is zwaar werk, je vreest voor je gezondheid, je mag je hoofddoek niet aanhouden",
                Voordelen = "Je doet ervaring op. Je budget is iets hoger.Je leert meer mensen kennen.",
                Resultaten = new List<Resultaat>()
            };
            t2v3.Antwoorden.Add(t2v3a1);
            antwoorden.Add(t2v3a1);

            Resultaat t2v3a1r1 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a1,
                Kans = 70,
                ResultaatTekst = "Je hebt het contract aangenomen en je hebt een job. Het zijn lange dagen, maar je bent tevreden dat je ervaring opbouwt.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<ResultaatVoorwaarde>()
            };
            t2v3a1.Resultaten.Add(t2v3a1r1);
            resultaten.Add(t2v3a1r1);

            Resultaat t2v3a1r2 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a1,
                Kans = 20,
                ResultaatTekst = "Je hebt het contract aangenomen, wanneer de subsidies stoppen word je onmiddellijk ontslagen.Ze zeggen dat het niets met je huidskleur te maken heeft, maar je hebt het gevoel dat dat toch wel meespeelt.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<ResultaatVoorwaarde>()
            };
            t2v3a1.Resultaten.Add(t2v3a1r2);
            resultaten.Add(t2v3a1r2);

            Resultaat t2v3a1r3 = new Resultaat()
            {
                ResultaatId = resultaten.Count + 1,
                Antwoord = t2v3a1,
                Kans = 10,
                ResultaatTekst = "Je hebt het contract aangenomen. Je koopt een wagen met je spaargeld, maar wordt opgelicht.Je geraakt niet op je werk en hebt hoge schulden.",
                ResultaatImageUrl = "someResultaatImgUrl",
                Voorwaarden = new List<ResultaatVoorwaarde>()
            };
            t2v3a1.Resultaten.Add(t2v3a1r3);
            resultaten.Add(t2v3a1r3);

            KeuzeAntwoord t2v3a2 = new KeuzeAntwoord()
            {
                AntwoordId = antwoorden.Count + 1,
                AntwoordKernTekst = "niet aannemen",
                AntwoordTekst = "IK WACHT OP EEN INTERESSANTER AANBOD",
                Vraag = t2v3,
                Nadelen = "Werkloosheidsuitkering zakt verder na een tijdje. Eenzaamheid",
                Voordelen = "Je beschikt over je eigen tijd. Je moet geen extra investeringen doen",
                Resultaten = new List<Resultaat>()
            };
            t2v3.Antwoorden.Add(t2v3a2);
            antwoorden.Add(t2v3a2);


            Thema t3 = new Thema()
            {
                ThemaId = themas.Count + 1,
                ThemaNaam = "vrije tijd",
                ThemaTekst = "Je krijgt vragen over werk",
                Standpunten = new List<PartijStandpunt>(),
                Vragen = new List<Vraag>(),
                ThemaImageUrl = "someThemaImgUrl"
            };

            Vraag t3v1 = new Vraag()
            {
                VraagId = vragen.Count + 1,
                Antwoorden = new List<Antwoord>(),
                Voorwaarden = new List<VraagVoorwaarde>(),
                VraagTekst = "Je hebt een stage gedaan via de VDAB in een restaurant in de keuken. Je krijgt een tijdelijk contract aangeboden aan het minimumloon. Je moet wel je hoofddoek afzetten tijdens het werk.",
                VraagKernTekst = "werken aan minimumloon?",
                Thema = t3,
                VraagImageUrl = "someVraagImgUrl"
            };
            t3.Vragen.Add(t3v1);
            vragen.Add(t3v1);
            //todo: dummydata verder aanvullen 

        }




        public Thema CreateThema(Thema thema)
        {
            thema.ThemaId = themas.Count + 1;
            themas.Add(thema);
            return thema;
        }


        public IEnumerable<Thema> ReadThemas()
        {
            return themas;
        }


        //todo: implement interface method
        public Vraag CreateVraag(Vraag vraag)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Vraag> ReadVragen()
        {
            return vragen;
        }

        //todo: implement interface method
        public IEnumerable<Vraag> ReadVragen(Thema thema)
        {
            throw new NotImplementedException();
        }

        //todo: implement interface method
        public Antwoord CreateAntwoord(Antwoord antwoord)
        {
            throw new NotImplementedException();
        }


        //todo: implement interface method
        public IEnumerable<Antwoord> ReadAntwoorden(Vraag vraag)
        {
            throw new NotImplementedException();
        }


        //todo: implement interface method
        public Resultaat CreateResultaat(Resultaat resultaat)
        {
            throw new NotImplementedException();
        }


        //todo: implement interface method
        public IEnumerable<Resultaat> ReadResultaten(Antwoord antwoord)
        {
            throw new NotImplementedException();
        }

    }
}
