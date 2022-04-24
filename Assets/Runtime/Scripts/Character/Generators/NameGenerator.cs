using System.Collections.Generic;
using UnityEngine;

/// <summary> Generators for Character Generation. </summary>
namespace RLSKTD.Character.Generators
{
    /// <summary> Generates a random name. </summary>
    sealed class NameGenerator
    {
        /// <summary> The list of first names. </summary>
        static private List<string> firstNames;
        /// <summary> The list of last names. </summary>
        static private List<string> lastNames;

        /// <summary> Initializes the name generator. </summary>
        static public string GenerateName(string race, string gender)
        {
            switch(race)
            {
                case "Human" :
                    HumanNames(gender);
                    break;
                case "Elf" :
                    ElfNames(gender);
                    break;
                case "Dwarf" :
                    DwarfNames(gender);
                    break;
                case "Gnome" :
                    GnomeNames(gender);
                    break;
                case "Goblin" :
                    GoblinNames(gender);
                    break;
                case "Fairy" :
                    FairyNames(gender);
                    break;
            }

            string characterName = firstNames[Random.Range(0, firstNames.Count)] + lastNames[Random.Range(0, lastNames.Count)];

            return characterName;
        }

        /// <summary> A Selection of Human Names. </summary>
        static private void HumanNames(string gender)
        {
            if(gender == "Male")
            {
                firstNames = new List<string>()
                {
                    "Garstaan ", "Balthioul ", "Ezekiel ", "Gadriel ", 
                    "Nanael ", "Seraphiel ", "Sarandiel ", "Bazazath ", "Ariuk ", 
                    "Iaoth ", "Eoried ", "Crynliar ", "Fornrydar ", "Zaranyxir ", 
                    "Rharaer ", "Inorylan ", "Borenolan ", "Fharlax ", "Charith ", 
                    "Charryn ", "Thalaer ", "Qurrad ", "Rizarlyx ", "Hyirlagar ", 
                    "Naharnex ", "Kuronith ", "Trazsahr ", "Vohrex ", "Eortar ", 
                    "Wahrenar ", "Gaiseric ", "Gouththas ", "Beucad ", "Fritigern ", 
                    "Wamba ", "Sadagares ", "Theoderid ", "Vetericus ", "Hildebad ", 
                    "Winguric ", "Rictiovarus ", "Theodehad ", "Respa ", "Videric ", 
                    "Recceswinth ", "Cunimund ", "Gento ", "Hernegliscus ", "Walahmar ", 
                    "Rechiar ", "Forni ", "Asvard ", "Mar ", "Berg " 
                };
            }
            else
            {
                firstNames = new List<string>()
                {
                    "Nahaliel ", "Duma ", "Amaliel ", "Anahita ", "Purah ",
                    "Domiel ", "Morael ", "Penemu ", "Azriel ", "Charmeine ",
                    "Areagne ", "Grynova ", "Irinera ", "Amelina ", "Hyrielle ",
                    "Qinnore ", "Sharrya ", "Ynisess ", "Xenvynia ", "Penona ",
                    "Rhelriane ", "Emelia ", "Brizeli ", "Brizriane ", "Daemnixi ",
                    "Nemorsha ", "Yrelthine ", "Daemney ", "Helchen ", "Aalissa ",
                    "Tryxsea ", "Zaehsea ", "Bwynrelle ", "Tinsea ", "Prisova ",
                    "Tinrya ", "Lynnlenne ", "Berinaris ", "Xennila ", "Tiness ",
                    "Berinorin ", "Qyranya ", "Meridyra ", "Drenvielle ", "Zelltyse ",
                    "Shariana ", "Wineli ", "Brunihild ", "Risthine ", "Ryrthine "
                };
            }

            lastNames = new List<string>()
            {
                "Cindershadow", "Northwind", "Eastwind", "Eastwood", "Northwood",
                "Longfire", "Dawnbeard", "Wiserock", "Hydrataker", "Hawkforge",
                "Covencrest" , "Plainshade", "Sacredgleam", "Fourflare", "Dreamdancer",
                "Amberbreath", "Longblood", "Sagesorrow", "Blazecrest", "Bladehammer",
                "Mountainhunter" , "Brightspell", "Hillflame", "Duskwater", "Noblebow",
                "Mason", "Stone", "Oak", "Lamagnac", "Nozin",
                "Saumtal", "Vernissac", "Dewwater", "Netherrider", "Dustlance", 
                "Aubegner", "Larmazin", "Bougairel", "Pembert", "Kergatillon", 
                "Aubenet", "Brichanteau", "Bizelon", "Sugre", "Roquetelet", 
                "Chaumont", "Vignon", "Sublimtal", "Angeveron", "Albelart", 
                "Ramburiou", "Ralot", "Lignidras", "Chanare", "Albiseul", 
                "Icebreath", "Pinetoe", "Leafstrength", "Alpenwatcher", "Bluesorrow", 
                "Wyvernwinds", "Summerstar" 
            };
            
        }

        /// <summary> A Selection of Elf Names. </summary>
        static private void ElfNames(string gender)
        {
            if(gender == "Male")
            {
                firstNames = new List<string>()
                {
                    "Mnementh ", "Eltaor ", "Elephon ", "Athtar ", "Elmon ",
                    "Taranath " , "Venali ", "Ayas ", "Elorshin ", "Adorellan ",
                    "Luvon ", "Elas ", "Illitran ", "Pelleas ", "Aquilan ",
                    "Elkhazel " , "Braern ", "Folmon ", "Folred ", "Edwyrd ",
                    "Hagluin ", "Halafarin ", "Ailmar ", "Taenaran ", "Aymar ",
                    "Tasar " , "Tannivh ", "Dain ", "Ryul ", "Ruven ",
                    "Filvendor ", "Pyrravyn ", "Respen ", "Beluar ", "Vulmer ",
                    "Ualiar " , "Illithor ", "Evindal ", "Nevarth ", "Klaern ",
                    "Mirthal ", "Olaurae ", "Jannalor ", "Otaehryn ", "Velethuil ",
                    "Ilvisar " , "Neremyn ", "Merith ", "Darcassan ", "Elidyr "
                };
            }
            else
            {
                firstNames = new List<string>()
                {
                    "Naesala ", "Yunaesa ", "Ghilanna ", "Yunaesa ", "Tinesi ",
                    "Gaylia " , "Darshee ", "Gaelira ", "Sarya ", "Vanya ",
                    "Yalanue ", "Nuala ", "Lensa ", "Ilythyrra ", "Glynnii ",
                    "Zilyana " , "Caerthynna ", "Shalendra ", "Holone ", "Vestele ",
                    "Maeralya ", "Anarzee ", "Lyra ", "Chalsarda ", "Yathanae ",
                    "Sana " , "Symania ", "Itylara ", "Yrneha ", "Aelynthi ",
                    "Cremia ", "Selphie ", "Maelyrra ", "Faraine ", "Cithrel ",
                    "Ara " , "Ciradyl ", "Sumina ", "Kylantha ", "Rallientha ",
                    "Renestrae ", "Neia ", "Merethyl ", "Syndra ", "Mhoryga ",
                    "Lusserina " , "Lithoniel ", "Renna ", "Saphielle ", "Imryll "
                };
            }

            lastNames = new List<string>()
            {
                "Adbella", "Faethana", "Inahana", "Vafiel", "Virkrana",
                "Miatoris" , "Vaceran", "Presrona", "Trarie", "Xyrfir",
                "Leonelis", "Qinroris", "Wranyarus", "Ralophine", "Vaphine",
                "Fayarus" , "Miaqen", "Daqen", "Chaedithas", "Holajeon",
                "Elakian", "Heijyre", "Dawynn", "Ulana", "Dorrie",
                "Lorawynn" , "Yllaris", "Ianvyre", "Zinleth", "Zumzeiros",
                "Brymaris", "Xyrnelis", "Lusalor", "Iansandoral", "Xyrzorwyn",
                "Ralocaryn" , "Enynore", "Zinjyre", "Brywarin", "Balric",
                "Trisra", "Bryjeon", "Magceran", "Fenpeiros", "Ilican",
                "Olorel" , "Neritoris", "Lucaryn", "Rowarin", "Caicaryn"
            };
        }

        /// <summary> A Selection of Dwarf Names. </summary>
        static private void DwarfNames(string gender)
        {
            if(gender == "Male")
            {
                firstNames = new List<string>()
                {
                    "Dhotruk ", "Lokkout ", "Gruzzur ", "Lolirlun ", "Hourrumlin ",
                    "Datdrig ", "Skakdrorli ", "Gruldrol ", "Sakum ", "Norarulir ",
                    "Henmorlum ", "Bakdron ", "Glarmeal ", "Urrolim ", "Otot ",
                    "Mognonlir ", "Whutam ", "Uggith ", "Brassorlim ", "Wedol ",
                    "Throlgrotum ", "Durikgror ", "Krosset ", "Hetmeag ", "Skakhat ",
                    "Haldruil " , "Andreal ", "Thatrer ", "Gromaeth ", "Brabrak ",
                    "Bhaghumi ", "Douzurim ", "Lorrad ", "Thandan ", "Hosaed ",
                    "Maboc " , "Elrfeg ", "Gobruc ", "Gadmouck ", "Deldrirlum ",
                    "Thratdraec ", "Jalmouck ", "Strolarlum ", "Dolgul ", "Doutmamri ",
                    "Grouggamli " , "Yorgreal ", "Neluil ", "Barilmoli ", "Umizmel "
                };

                
            }
            else
            {
                firstNames = new List<string>()
                {
                    "Throretalyn ", "Jomreada ", "Umimnagaer ", "Brouzzeataine ", "Yastathra ",
                    "Thradraetryd " , "Noraloula ", "Alfommetalyn ", "Werarhealda ", "Khuseada ",
                    "Thraggtryd ", "Voseahulda ", "Nossalydd ", "Grundore ", "Werarnodeth ",
                    "Nokeala " , "Dugragar ", "Thunduirgit ", "Dazzabela ", "Dhureanelyn ",
                    "Krawestr ", "Brakaehilda ", "Strokitelin ", "Okhuilyn ", "Herfihilda ",
                    "Thostaebyrn " , "Losaerika ", "Erigneginn ", "Bazzeagar ", "Mokgruda ",
                    "Nedgrunelynn ", "Dhuwedrid ", "Bradgriserd ", "Thraddebelyn ", "Gosdrurika ",
                    "Thirreatain " , "Kidruwynn ", "Thukhatalyn ", "Nanmatalin ", "Uthaeda ",
                    "Dardrihilde ", "Werargoubena ", "Samnouhilda ", "Bofolydd ", "Skorfaegith ",
                    "Fosarika " , "Dwonwaetrude ", "Grouzzubena ", "Nurafaline ", "Krolmutrud "
                };
            }

            lastNames = new List<string>()
            {
                "Cavebasher", "Icerock", "Boulderhood", "Bonemane", "Giantmantle",
                "Coalminer" , "Honorhorn", "Marblefall", "Browndelver", "Brightjaw",
                "Hillthane", "Trollchest", "Wardigger", "Heavyjaw", "Anvilblade",
                "Snowfinger" , "Silverforge", "Bluntgrip", "Smeltbreaker", "Earthbreaker",
                "Trollriver", "Ashstone", "Cragarm", "Emberarm", "Merrybender",
                "Snowbeard" , "Giantdigger", "Caskhood", "Oregrip", "Deepjaw",
                "Chaosgrip", "Sapphirebrewer", "Oakfall", "Flatmantle", "Jadebrand",
                "Leadmaker" , "Greyhead", "Graybraids", "Axepike", "Smeltshoulder",
                "Giantmaster", "Chainhide", "Onyxstone", "Granitebrand", "Pebblehood",
                "Giantmace" , "Shattercoat", "Ingotfury", "Brewarmour", "Granitemaster"
            };
        }

        /// <summary> A Selection of Gnome Names. </summary>
        static private void GnomeNames(string gender)
        {
            if(gender == "Male")
            {
                firstNames = new List<string>()
                {
                    "Sminbug ", "Jammip ", "Fruddnist ", "Naanziest ", "Begnurt ",
                    "Knimdyrt ", "Slapnacep ", "Lybbricer ", "Knedankkop ", "Mulidboss ", 
                    "Frikpet ", "Sniensbuck ", "Knoprirt ", "Ninsmiest ", "Sladbim ", "Cliddwomag ",
                    "Gneddwevoog ", "Fremillbert ", "Robilkig ", "Slisirick ", "Cippust ", 
                    "Nudnyst ", "Tidnack ", "Nelkur ", "Jembim ", "Snunsnovit ", "Tidnibyck ",
                    "Tolikwoc ", "Tunieknyss ", "Slumenkkap ", "Mibkirt ", "Zygbast ", 
                    "Bevip ", "Clupnyc ", "Zerbet ", "Knaanjivig ", "Hombivurt ", "Boovagbor ",
                    "Gehemzeeck ", "Slymikwust ", "Friddwist ", "Nensmeem ", "Klaamtert ", 
                    "Snoobbneck ", "Jinzom ", "Gerwegac ", "Klibbridoss ", "Gimoppock ", "Comilbeeg ",
                    "Gnuwigboost ", "Hevem ", "Tooret ", "Snensbir ", "Clibbrem ", "Lerbim ",
                    "Bensneger ", "Slerkadip ", "Sceverwap ", "Clemiddack ", "Jyvuddwart ", "Pibnost ",
                    "Fronkkag ", "Dansmem ", "Wubbnir ", "Knippum ", "Damwienim ", "Gnamdigyst "
                };
            }
            else
            {
                firstNames = new List<string>()
                {
                    "Cilwup ", "Sholbem ", "Thylva ", "Flapwen ", "Gnipwath ",
                    "Smilmidel ", "Thonsnafa ", "Smanerbul ", "Shadonbos ", "Fawilmum ", 
                    "Gnumwuth ", "Glulbes ", "Blakwyt ", "Sneblass ", "Tiblan ", "Ignofa ",
                    "Nillnisooss ", "Welibbnep ", "Bliwagne ", "Tafuddwir ", "Gnobnuss ", 
                    "Fnypnyl ", "Slari ", "Shedwot ", "Flyddleeth ", "Sluddwaihel ", "Ibledy ",
                    "Myfible ", "Lawalnu ", "Fleleddlyr ", "Maaddwet ", "Glidlyl ", 
                    "Smupwat ", "Perwy ", "Mainkar ", "Gomwaseell ", "Ibnaloth ", "Cewepnyth ",
                    "Gavabbnaass ", "Niwiblar ", "Winklath ", "Shibble ", "Gnomwir ", 
                    "Wibnet ", "Sloollnir ", "Geblaibot ", "Meddawiss ", "Phuwallba ", "Heelepnim ",
                    "Havavith ", "Tubneth ", "Fleddwit ", "Fnensnop ", "Snolmol ", "Phulwe ",
                    "Clipnewat ", "Glenklodi ", "Clovurbar ", "Iedaarbaal ", "Phivamman ", "Shugne ",
                    "Wakmees ", "Gneddweell ", "Worath ", "Cappar ", "Slekwaiwap ", "Lalvovai "
                };
            }

            lastNames = new List<string>()
            {
                "Bilbeeck", "Thamjoock", "Thydbeck", "Wynsmart", "Papwoll",
                "Fnellmynan" , "Madbigeck", "Smynegbart", "Jaavenkliss", "Lihillmis",
                "Lirki", "Cokus", "Scalbe", "Glaagbos", "Fleedbag",
                "Injigiem" , "Ybkesan", "Owimdill", "Cleherbe", "Demaanker",
                "Slelbell", "Darbiep", "Badlim", "Nobbnuss", "Coddast",
                "Phibkeryp" , "Lakpulaas", "Klesiprim", "Scubyppyll", "Gnafagbes",
                "Dumwil", "Fnegnyr", "Slonkles", "Shikweck", "Clenza",
                "Fnampaiget" , "Binsmely", "Idekpit", "Gevanjoc", "Adabnir",
                "Rapre", "Clonglir", "Sninje", "Maibbnert", "Nikwu",
                "Shadneran" , "Akpasoock", "Tebumjyn", "Navymdurt", "Scehommert"
            };
        }

        /// <summary> A Selection of Goblin Names. </summary>
        static private void GoblinNames(string gender)
        {
            if(gender == "Male")
            {
                firstNames = new List<string>()
                {
                    "Leelk ", "Vrekz ", "Ubs ", "Wrosb ", "Wrut ",
                    "Antot ", "Vrilveelb ", "Rebuirt ", "Chogsiag ", "Gretzoc ",
                    "Iet ", "Bobs ", "Lits ", "Rard ", "Uts ",
                    "Olteakx ", "Wimex ", "Staveags ", "Gnuidhukt ", "Xieheeg ",
                    "Xolx ", "Raar ", "Ziact ", "Bleegs ", "Ot ",
                    "Pytrakx ", "Plialorx ", "Preekvaank ", "Zrearmosz ", "Zarmoird ",
                    "Stigs ", "Braalx ", "Erm ", "Tekz ", "Gliok ",
                    "Ibos ", "Kedseebs ", "Kric ", "Vuikz ", "Eazz ",
                    "Trank ", "Bluct ", "Strydiark ", "Criessekx ", "Liastir ",
                    "Tyvucs ", "Reezgiat ", "Barx ", "Jegs ", "Turt "
                };
            }
            else
            {
                firstNames = new List<string>()
                {
                    "Aszia ", "Rirx ", "Gris ", "Jygs ", "Gug ",
                    "Utifs ", "Staavlulx ", "Wiabril ", "Kaviels ", "Frabdethee ",
                    "Bhuns ", "Trolse ", "Biang ", "Onxia ", "Eelm ",
                    "Lagtuls ", "Wiaskioszea ", "Briesriarti ", "Clublysh ", "Flirvuh ",
                    "Ronia ", "Trux ", "Molk ", "Asx ", "Iftia ",
                    "Wrefneax ", "Paaptunxa ", "Weanvoq ", "Thoghihx ", "Kapmunk ",
                    "Urxi ", "Slaalm ", "Theerx ", "Ilt ", "Urt ",
                    "Soihusx ", "Agmelk ", "Klisbulsea ", "Srehon ", "Gnykonx ",
                    "Cliong ", "Swasx ", "Iefze ", "Gnerta ", "Brisx ",
                    "Khuigliefee ", "Bamefz ", "Slirdelkia ", "Fulonx ", "Iagzartai "
                };
            }

            lastNames = new List<string>()
            {
                "Roughhunter", "Bronzedane", "Moonhair", "Chestcrest", "Mossbough",
                "Deathblood" , "Roughsinger", "Roughbraid", "Chestflower", "Wheatkiller",
                "Willowcrag", "Marblevigor", "Flintbone", "Hellwhisper", "Ironchaser",
                "Darkwinds" , "Palevale", "Downroot", "Noseglory", "Rosestrider",
                "Mildcloud", "Wheatblaze", "Axestar", "Dragonblaze", "Masterfallow",
                "Stagbreeze" , "Wyvernrider", "Starbough", "Flatspear", "Moonvalor",
                "Longfire", "Dawnbeard", "Wiserock", "Hydrataker", "Hawkforge",
                "Covencrest" , "Plainshade", "Sacredgleam", "Fourflare", "Dreamdancer",
                "Amberbreath", "Longblood", "Sagesorrow", "Blazecrest", "Bladehammer",
                "Mountainhunter" , "Brightspell", "Hillflame", "Duskwater", "Noblebow"
            };
        }

        /// <summary> A Selection of Fairy Names. </summary>
        static private void FairyNames(string gender)
        {
            if(gender == "Male")
            {
                firstNames = new List<string>()
                {
                    "Bear ", "Sneezy ", "Sunrise ", "Ocean ", "Cosmo ",
                    "Brock " , "Timber ", "Sky ", "Miles ", "Onyx ",
                    "Quicksilver ", "Rocky ", "Shade ", "Happy ", "Aphid ",
                    "Quinn " , "Bracken ", "Reef ", "Moptop ", "Pistachio ",
                    "Tarragon ", "Alaneo ", "Peridot ", "Timothy ", "Blathnat ",
                    "Pine " , "Snowdrop ", "Mountain ", "Sprinkle ", "Stormy ",
                    "Daybreak ", "Sprinkle ", "Tidal ", "Bramble ", "Pyro ",
                    "Nightfall " , "Karma ", "Cloud ", "Lightning ", "Skylark ",
                    "Basil ", "Strombo ", "Firo ", "Bim ", "Plume ",
                    "Oleander " , "Mango ", "Ash ", "Earth ", "Silver "
                };
            }
            else
            {
                firstNames = new List<string>()
                {
                    "Buttercup ", "Penelope ", "Moonbean ", "Ella ", "Lynne ",
                    "Tinkerbell " , "Eve ", "Heather ", "Grevillea ", "Calico ",
                    "Stormy ", "Rafflesia ", "Betty ", "Jewel ", "Leeta ",
                    "Forsythia " , "Belladonna ", "Dey ", "Feu ", "Sulcore ",
                    "Ionia ", "Nimbus ", "Apricot ", "Hyacinth ", "Peoni ",
                    "Posey " , "Flamo ", "Dragonfly ", "Rachel ", "Peachy ",
                    "Iris ", "Rosalind ", "Orange ", "Faye ", "Dew ",
                    "Prudence " , "Mildread ", "Jade ", "Magnola ", "Sky ",
                    "Yasmine ", "Camie ", "Dandelia ", "Octavia ", "Wren ",
                    "Kesiray " , "Salle ", "Tinder ", "Spore ", "Coral "
                };
            }

            lastNames = new List<string>()
            {
                "Lemonflower", "Jumpymint", "Turtleglow", "Seabeam", "Dapplespice",
                "Jestermint" , "Wildfleck", "Redglimmer", "Beautyfig", "Bluevale",
                "Pearhill", "Shinybloom", "Olivetwill", "Islandwort", "Dimplefoam",
                "Rainysage" , "Mountainspirit", "Lovelyflip", "Jellydance", "Rainyflash",
                "Foggywind", "Pumpkinstripe", "Pollenglow", "Palmfoot", "Birdnoodles",
                "Windyfluff" , "Windymuddle", "Flirtyfig", "Briargourd", "Wildjewel",
                "Blacknut", "Whitemint", "Muddybelle", "Shimmerwort", "Birdwhite",
                "Jingleclover" , "Beautyflash", "Parsleywink", "Redshimmer", "Thundertwinkle",
                "Petaldust", "Tuliptoes", "Vanillapetal", "Lotusvalley", "Mapleripple",
                "Lemonmuddle" , "Sugarswamp", "Pineflip", "Rosewort", "Hollybreeze"
            };
        }
    }
}