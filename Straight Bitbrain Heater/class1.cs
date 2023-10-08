
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Straight_Bitbrain_Heater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public static Boolean RNGKeysInitiated = false;
        public static string Start3(string[] E10EreturnArray)
        {
            
            set_modify_time_place = false;
            set_place = false;
            set_time = false;
            set_aspercream = false;
            
            string E10Ereturn = pick(E10EreturnArray, "e10earray");
           
            E10Ereturn = replace_func(E10Ereturn);
            
            return E10Ereturn;
        }
        public static string[] linkArray = { "cuz","so","and","since","when","while" };

        public static Boolean set_place = false;
        public static Boolean set_time = false;
        public static Boolean set_modify_time_place = false;
        public static Boolean set_aspercream = false;

        public delegate string nanodels();

        public static string DuplicateInfo = "";

        public static Dictionary<string, List<int>> PickTable = new Dictionary<string, List<int>>();

        public static string pick(string[] ArrayToPickFrom, string arrname)
        {           
            int t;
            string newarrname = arrname + ArrayToPickFrom.Length;

            if (!PickTable.ContainsKey(newarrname))
            {
                PickTable.Add(newarrname, new List<int>());
            }
            if (PickTable[newarrname].Count == 0)
            {
                for (int i = 0; i < ArrayToPickFrom.Length; i++)
                {
                    PickTable[newarrname].Add(i);
                }
            }
            int p = PickTable[newarrname].Count;
            t = RandomNumber.Rand4(p);            
            string PickReturn = ArrayToPickFrom[PickTable[newarrname][t]] + " ";
            PickTable[newarrname].RemoveAt(t);
            return PickReturn;
        }

        
        public static string get_a(string str)
        {
            if (str.Length == 0) { return ""; }
            if ("aeiouAEIOU".Contains(str[0].ToString()))
            {
                return "an " + str;
            }
            else
            {
                return "a " + str;
            }
        }
        public static string[] bit_face = new string[] {"bitbrain mole face","bitbrain cut face","bitbrain copy bit","bitbrain tattle tale","bitbrain burnt hair","bitbrain know nothing","bitbrain pants"
        };
        public static string[] james_thought_list = new string[] {"non sense non sense sense is your ass killed", "E1 point 0E", "james is twice the effect with out the meaning",
            "you cause you","not finished i have to laugh",
            "james knows the effect with out knowing the meaning",
            "evacuate green line",
            "pure sense","james started his own shadow idea","black when black","james is green when red","green pyramids","colored candy","dracula","2 6 9 chess A D","long way out","things not things","james stopped reality",
            "shadow coincidence","perfect thought disorder"
        };
        public static string[] far_thought_list = new string[] {"non sense non sense sense is your ass killed", "E1 point 0E", "twice the effect with out the meaning",
            "you cause you","not finished i have to laugh",
            "james knows the effect with out knowing the meaning",            
            "evacuate green line",
            "pure sense","shadow idea","black when black","green when red","perfect thought disorder","shadow coincidence",
            "Dracula","long way out","things not things","green pyramids","colored candy","2 6 9 chess A D",
            "far thought","james stopped reality","shadow service inc","gold pyramid","james is smart and hot","G Therm",
            "bossy","scorpion with star destroyer fists","shadow creature with equation face"
        };
        public static string[] far_thought_lists = new string[] {"non sense non sense sense is your ass killeds", "E1 point 0 Ees", "twice the effect with out the meanings","far thoughts",
            "pure senses","perfect thought disorders",
            "you cause yous","not finished i have to laughs","green pyramids","shadow coincidences","evacuate green lines","james knows the effect with out knowing the meanings",
            "things not things","long way outs","james stopped realities","james is smart and hots",
            "green even when he's reds","269 Chess A Dees","shadow ideas","greens","scorpions","draculas","colored candies","shadow service incorporateds",
            "rockys","daniel in minnesota's","ricky's","jackie's","amanda moshier's","marcy's",

        };
        public static string[] far_thought_listed = new string[] {"non sense non sense sense is your ass killed", "E1 point 0 Eed", "twice the effect with out the meaninged","far thoughted",
            "pure sensed","perfect thought disordered",
            "you cause you'ed","not finished i have to laughed","green pyramidsed","shadow coincidenced","evacuate green lined","james knows the effect with out knowing the meaninged",
            "things not thingsed","long way outed","james stopped realitied","james is smart and hotted",
            "green even when he's redded","269 Chess A Deed","shadow ideaed","green","scorpioned","draculad","colored candied","shadow service incorporated",
            "rocky'ed","daniel in minnesota'ed","rickied","jackie'd","amanda moshiered","marcied",
        };
        public static string[] far_thought_listing = new string[] {"non sense non sense sense is your ass killeding", "E1 point 0 Eeing", "twice the effect with out the meaninging","far thoughting",


            "pure sensing","perfect thought disordering",
            "you cause youing","not finished i have to laughing","green pyramidsing","shadow coincidencing","evacuate green lining","james knows the effect with out knowing the meaninging",
            "things not thingsing","long way outing","james stopped realitying","james is smart and hotting",
            "green even when he's redding","269 Chess A Deeing","shadow ideaing","greening","scorpioning","draculaing","colored candying","shadow service incorporateding",
            "rockying","daniel in minnesota in","ricky's","jackie in","amanda moshier in","marcy in",        };
        public static string[] far_thought_listy = new string[] {
            "non sense non sense sense is your ass killedy", "E1 point 0 Ee e", "twice the effect with out the meaningy","far thoughty",
            "pure sense e","perfect thought disordery",
            "you cause you-e","not finished i have to laughy","green pyramidsy","shadow coincidency","evacuate green liny","james knows the effect with out knowing the meaningy",
            "things not thingsy","long way outy","james stopped reality e","james is smart and hotty",
            "green even when he's reddy","269 Chess A Dee e","shadow idea e","greeny","scorpiony","dracula e","colored candy e","shadow service incorporatede",
            "rocky e","daniel in minnesota e","ricky e","jackie e","amanda moshier e","marcy e",
        };

        public static string[] place_mofos = new string[] { "american", "european", "chinese", "japanese", "north american", "middle eastern", "australian", "asian", "south side", "north side",
            "west side", "east side" };

        public static string[] bitch_s = new string[] {  "girl's", "chick's", "sister's",
                "woman's", "wife's", "girl friend's", "fiancé's","bitch's","sluts","hoes","prom queen's","princess'","queen's" };

        public static string[] bitches = new string[] {  "girls", "chicks", "sisters",
                "women", "wives", "girl friends", "fiancés","bitches","sluts","hoes","prom queens","princesses","queens" };


        public static string[] bitch = new string[] {  "girl", "chick", "sister",
                "woman", "wife", "girl friend", "fiancé","bitch","slut","hoe","prom queen","princess","queen" };

        public static string[] handgun = new string[] { "gun", "heater", "pistol", "nine millimeter", "four five", "M nineteen eleven", "revolver", "saturday night special", "artillery piece" };
        public static string[] handguns = new string[] { "guns", "heaters", "pistols", "nine millimeters", "four fives", "M nineteen elevens", "revolvers", "saturday night specials", "artillery pieces" };
        public static string[] gun = new string[] { "AK forty seven", "M sixteen", "M4" };
        public static string[] guns = new string[] { "AK forty sevens", "M sixteens", "M fours" };
        public static string[] food_list = new string[] {"apple","ice cream cone","banana split","rib eye","cowboy ribeye","filet mignon","pork chop","blooming onion","chicken wing","taco","taco salad","stew","roast",
        "hamburger","cheese burger","sushi roll","bowl of curry chicken","plate of vindaloo lamb","lamb chop","piece of fried chicken","watermelon","orange","banana","lobster","pizza","plate of pasta"};
        public static string[] foods_list = new string[] {"apples","ice cream cones","banana splits","rib eyes","cowboy ribeyes","filet mignons","pork chops","blooming onions","chicken wings","tacos","taco salads","stew","roasts",
        "hamburgers","cheese burgers","sushi rolls","bowls of curry chicken","plates of vindaloo lamb","lamb chops","fried chicken","watermelons","oranges","bananas","lobsters","crab cakes","pizzas"};
        public static string get_james_thought_list()
        {
            return pick(james_thought_list, "james_thought_list");
        }
        public static string get_far_thought_list()
        {
            return pick(far_thought_list, "far_thought_list");
        }
        public static string get_bit_face()
        {
            return pick(bit_face, "bit_face");
        }
        public static string get_aspercream_bitches()
        {
            return get_aspercream_mofos(bitches);
        }
        public static string get_bitbrain_bitches()
        {
            return get_bitbrain_mofo(bitches);
        }
        public static string get_a_bitbrain_bitch()
        {
            return get_a(get_bitbrain_mofo(bitch));
        }
        public static string get_bitbrain_bitch()
        {
            return get_bitbrain_mofo(bitch);
        }
        public static string get_bitbrain_bitch_or_bitches()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_a(get_bitbrain_bitch()) : get_bitbrain_bitches();
        }
        public static string get_food_list()
        {
            return pick(food_list, "food_list");
        }
        public static string get_food_lists()
        {
            return pick(foods_list, "foods_list");
        }
        public static string get_handgun()
        {
            string str = get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return get_a(str + pick(handgun, "handgun"));
        }
        public static string get_handguns()
        {
            string str = get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return str + pick(handguns, "handguns");
        }
        public static string get_guns()
        {
            string str = "";
            str += get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return str + pick(guns.Concat(handguns).ToArray(), "handguns");
        }
        public static string get_gun()
        {
            string str = "";
            str += get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return str + pick(gun.Concat(handgun).ToArray(), "handgun");
        }
        public static string geta_gun()
        {
            string str = "";
            str += get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return get_a(str + pick(gun, "gun"));
            
        }
        public static string get_adverb()
        {
            if (RandomNumber.Rand4(2) == 0)
            {
                //return pick(AdverbQuantity, "adverb");
            }
            return "";
        }
        public static string get_bit_modifying()
        {
            return get_adverb() + " " + pick(bit_modifying, "bit_modifying");
        }
        public static string get_bit_modifies()
        {
            return get_adverb() + " " + pick(bit_modifies, "bit_modifies");
        }
        public static string get_bit_modified()
        {
            return get_adverb() + " " + pick(bit_modified, "bit_modified");
        }
        public static string get_bit_modify()
        {

            return get_adverb() + " " + pick(bit_modify, "bit_modify");
        }
        public static string[] AdverbQuantity = new string[] { "not","gleefully","terribly","quite","rather","boldly","bravely","very", "kind of","somewhat","a little","awfully","ridiculously","extremely","a tiny bit" };
        public static string get_a_bit_modify()
        {
            return get_a(pick(bit_modify, "bit_modify"));
        }
        public static string get_bit_modify_y()
        {
            return get_adverb() + " " + pick(bit_modify_y, "bit_modify_y");
        }
        public static string get_a_nano_modify()
        {
            return get_a(get_far_thought_list());
        }
        public static string get_nano_modify()
        {
            return get_adverb() + " " + pick(nano_modify, "far_thought_list");
        }
        public static string get_nano_modified()
        {
            return get_adverb() + " " + pick(nano_modified, "nano_modified");
        }
        public static string get_nano_modify_y()
        {
            return get_adverb() + " " + pick(nano_modify_y, "nano_modify_y");
        }
        public static string get_nano_modifies()
        {
            return get_adverb() + " " + pick(nano_modifies, "nano_modifies");
        }
        public static string get_nano_modifying()
        {
            return get_adverb() + " " + pick(nano_modifying, "nano_modifying");
        }
        public static string get_aspercream_bitch()
        {
            return get_a(get_aspercream_mofos(bitch));
        }
        public static string[] aspercreammofo = new string[] { "man", "boy", "police officer", "gangster", "baller", "player", "outlaw", "lawyer", "rapper", "country singer", "person",
            "mobster", "enforcer", "hitman","drug dealer","naval aviator","navy SEAL","G","husband","dictator","god king","president","pope","hang man","executioner","bitbrain killer",
        "[get_nano_modify] styler","killer","rider","drug kingpin","soldier","government agent","mafia don","nano prisoner","cow boy","movie star","aristocrat","lord",
        "prince","king","general","admiral","gentleman","president of Nanopol","Nanopol officer","F.B.I. Agent","C.I.A. agent","N.S.A. agent","microsoft employee","jedi knight","sith lord","hustler","star pirate","astronaut",
        "nano dungeon naut","basket ball player","football player","alien","monster","stranger","demon","angel","prophet","clairvoyant","psychic","detective","mercenary","ghost","nomad","assassin","emperor",
        "submarine captain","wizard","warlock","magician","necromancer","sorcerer","dragon","troll","seventh son of a seventh son","mystic","incubus","cave man",
        "barbarian","starship captain","comedian","politician","judge","journalist","warrior","godzilla","adventurer","prince of {the [get_nanodungeon_of_doom]|darkness}","time traveler","little green man","gray","revolutionary","knight",
        "duke","spartan warrior","prisoner","guard","inmate","driver","white knight","pilgrim","private","davy jones","darth vader","hero","pirate","ninja","sniper","dark lord","god","rebel","privateer","buccaneer",
        "daredevil","swashbuckler","baron","commander","don","overlord","ruler","seer","shaman","secret agent","cyborg","robot","terminator","boss player","shot caller","thug","rap star","ghetto star","mack","mack daddy","Lo Pan","storm",
        "thunder","crom","juggalo","nano dungeon of doom star","centaur","vampire","were wolf","were beast","were bear","monk","shaolin monk","general","dragon","vampire","god","titan","demon",

        };

        public static string get_no_a_aspercream()
        {
            set_aspercream = true;
            return (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(aspercreammofo)) : pick(aspercream, "aspercream");
        }

        public static string get_a_aspercream()
        {
            set_aspercream = true;
            return get_a(get_far_thought_list());//  get_aspercream_mofos(aspercreammofo));
        }
        public static string get_aspercream()
        {
            set_aspercream = true;
            return pick(aspercream, "aspercream");
        }
        public static string get_aspercreaming()
        {
            string[] mofoing = new string[] { "manning", "boying", "police officering", "gangstering", "ballering", "playering", "outlawing", "lawyering", "rappering", "country singering", "personing",
            "mobstering", "enforcering", "hitmanning","drug dealering","playering","shot callering","naval aviatoring","navy SEALing","Gee-ing","husbanding","dictatoring","god kinging","presidenting","poping",
        "hang manning","executionering","bitbrain killering",
        "[get_nano_modify] stylering","killering","ridering","drug kingpining","soldiering","government agenting","mafia donning","nano prisonering","cow boying","movie starring","aristocratting","lording",
        "princing","kinging","generalling","admiralling","gentlemanning","president of Nanopoling","Nanopol officering","F.B.I. Agenting","C.I.A. agenting","N.S.A. agenting","microsoft employee-ing","jedi knighting","sith lording","starship captaining",
        "hustlering","star pirating","cromming","centauring"};
            set_aspercream = true;
            return (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(mofoing)) : pick(aspercreaming, "aspercreaming");
        }
        public static string get_aspercream_s()
        {
            string[] mofo_s = new string[] { "man's", "boy's", "police officer's", "gangster's", "baller's", "player's", "outlaw's", "lawyer's", "rapper's", "country singer's", 
                "mobster's", "enforcer's", "hitman's","drug dealer's","player's","shot caller's","naval aviator's","navy SEAL's","Gee's","husband's","god king's","president's","pope's","hang man's","executioner's",
        "bitbrain killer's","[get_nano_modify] styler's","killer's","rider's","drug kingpin's","soldier's","government agent's","mafia don's","nano prisoner's","cow boy's","movie star's","aristocrat's","lord's",
        "prince's","king's","general's","admiral's","gentleman's","Nanopol officer's","president of Nanopol's","F.B.I. Agent's","C.I.A. agent's","N.S.A. agent's","microsoft employee's","jedi knight's","sith lord's","starship captain's",
        "hustler's","star pirate's","astronaut's","warrior's","nano dungeon naut's","basket ball player's","football player's","alien's","monster's","stranger's","demon's","angel's","prophet's","clairvoyant's","psychic's","detective's",
                "mercenary's","ghost's","nomad's","assassin's","emperor's","dictator's",
        "submarine captain's","wizard's","warlock's","magician's","necromancer's","sorcerer's","dragon's","troll's","seventh son of a seventh son's","mystic's","incubus'","freddy krueger's","jason voorhees's","king kong's","cowboy's",
                "cave man's","barbarian's","starship captain's","comedian's","politician's","judge's","president's","journalist's","warrior's","godzilla's","adventurer's","prince of darkness'","time traveler's","little green man's","gray's","revolutionary's","knight's",
        "duke's","spartan warrior's","prisoner's","guard's","inmate's","driver's","hero's","boss player's","shot caller's","thug's","rap star's","ghetto star's","mack's","mack daddy's","crom's","juggalo's",
        "nano dungeon of doom's star's","centaur's"
        };
            set_aspercream = true;
            return pick(aspercream_s, "aspercream_s");
        }
        public static string get_aspercream_any()
        {
            set_aspercream = true;
            return get_a(get_far_thought_list());// (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(aspercreammofo)) : pick(aspercream, "aspercream");
            //return RandomNumber.Rand4(2) == 0 ? get_aspercream_bitch_or_bitches() : get_aspercream_or_aspercreams();
        }
        public static string get_aspercream_mofos_or_bitches()
        {
            return get_a(get_far_thought_list());// (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(aspercreammofo)) : pick(aspercream, "aspercream");
            //return RandomNumber.Rand4(2) == 0 ? get_aspercreams() : get_aspercream_mofos(bitches);
        }
        public static string get_aspercream_bitch_or_bitches()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_aspercream_bitch() : get_aspercream_mofos(bitches);
        }
        public static string get_aspercream_mofos(string[] aspercream_array)
        {
            //return get_a(get_far_thought_list());// (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(aspercreammofo)) : pick(aspercream, "aspercream");
            
            set_aspercream = true;
            StringBuilder str = new StringBuilder();
            str.Append(pick(far_thought_list, "far_thought_list"));
            //str.Append(get_mofo_meta());
            str.Append(pick(aspercream_array, "aspercream_array"));
            return str.ToString();
            
        }
        public static string get_mofo_meta()
        {
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(pick(place_mofos, "place_mofos"));
            }            
            return str.ToString();
        }
        public static string get_aspercreams()
        {
            string[] mofos = new string[] { "men", "boys", "police officers", "gangsters", "ballers", "players", "outlaws", "lawyers", "rappers", "country singers",
            "people", "mobsters", "enforcers", "hitmen","drug dealers","shot callers","naval aviators","navy SEALs","Gees","husbands","dictators","presidents","hang men","executioners","bitbrain killers",
        "[get_nano_modify] stylers","killers","riders","drug kingpins","soldiers","government agents","mafia dons","nano prisoners","cow boys","movie stars","aristocrats","lords",
        "princes","kings","generals","admirals","gentlemen","Nanopol officers","F.B.I. Agents","C.I.A. agents","N.S.A. agents","microsoft employees","jedi knights","sith lords","hustlers","star pirates","astronauts",
        "nano dungeon nauts","basket ball players","football players","aliens","monsters","strangers","demons","angels","prophets","clairvoyants","psychics","detectives","mercenaries","ghosts","nomads","assassins","emperors","popes",
        "submarine captains","wizards","warlocks","magicians","necromancers","sorcerers","dragons","trolls","seventh sons of seventh sons","mystics","cowboys","cave men","barbarians","starship captains","comedians","politicians",
                "judges","journalists","warriors","adventurers","time travelers","little green men","grays","revolutionaries","knights","dukes","spartan warriors","prisoners","guards","inmates","drivers","grim reapers","heroes",
                "robots","cyborgs","terminators","boss players","thugs","juggalos","nano dungeon of doom stars"

        };
            set_aspercream = true;
            return get_aspercream_mofos(mofos);
        }

        public static string get_aspercream_or_aspercreams()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_aspercreams() : get_aspercream();
        }
        public static string get_no_a_bitbrain()
        {
            return get_bitbrain_mofo(bitbrain);
        }
        public static string get_bitbrain()
        {
            return get_a(get_bitbrain_mofo(bitbrain));
        }
        public static string get_bitbrains()
        {
            return get_bitbrain_mofo(bitbrains);
        }
        public static string get_bitbrain_s()
        {
            return get_a(get_bitbrain_mofo(bitbrain_s));
        }
        public static string get_a_bitbrain_or_bitbrains()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_bitbrain() : get_bitbrains();
        }
        public static string pick_bitbrain(string[] bitbrain_array)
        {
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(4) == 0)
            {
                str.Append(pick(mental, "mental"));
            }
            str.Append(pick(bit_modify, "bit_modify"));
            str.Append(pick(bitbrain_array, "bitbrain_array"));
            return str.ToString();
        }
        public static string[] bitbrain_mofo = new string[] { "bastard", "bitler",
            "bit hole", "bit holer","fool" };
        public static string[] bitbrain_mofos = new string[] {"bastards", "bitlers",
            "bit holes", "bit holers" };
        public static string[] bitbrain_mofo_s = new string[] { "bastard's",
            "bitler's", "bit hole's", "bit holer's" };
        public static string[] aspercream = new string[] {
            "[get_far_thought] James Gentilly","the {war lord|dark lord|demon|over lord|demon lord|god|titan|hell lord|angel|dark angel} james gentilly who {was not finished I have to laugh|said nonsense nonsense sense is your ass killed|knew the effect without knowing the meaning|you cause you}","Counter nanoterrorist Strike Force Agent James Gentilly" };
        public static string[] aspercreaming = new string[] { "Aspercreaming", "Bitbrain Killering", "Mister E1 point 0Eing", "Twice the effect with out the meaninging", "nano prisonering","Counter nanoterrorist Strike Force Agent James Gentilly in" };
        public static string[] aspercream_s = new string[] { "Counter nanoterrorist Strike Force Agent James Gentilly's",
            "[get_far_thought] James Gentilly's",};
        public static string get_bitbrain_mofo(string[] bitbrain_array)
        {
            StringBuilder str = new StringBuilder();

            if (RandomNumber.Rand4(4) == 0)
            {
                str.Append(pick(mental, "mental"));
            }
            str.Append(pick(bit_modify, "bit_modify"));

            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(get_mofo_meta());
            }

            str.Append(pick(bitbrain_array, "bitbrain_array"));
            //str.Append(pick(bitbrain, "dumb_bitbrain"));
            return str.ToString();

        }
        public static string get_mental()
        {
            return pick(mental, "mental");
        }            
    
        public static string[] mental = new string[] { "KG Bit","red","rebitted"};

        public static string[] bitbrain = new string[] {
    "bitler","seven hundred megabyter","submariner","one bit per second err","bit brain nano terrorist",
        "no wayer","rebit","nano dungeon err","bitter","leafer",
    "bravo's racist fistser","bit brain","bit hole","bit holer",
"louisiana brain deather","nano terrorist","bit caller","billy bits","bit master","KG Bit Agent","bit cerveau",
"bitler","even hundred megabyter","submariner","bitbrain nano terrorist",
"no wayer","bitter","leafer",
"bitbrain","bit hole","bit holer","louisiana brain deather","nanoterrorist","bit caller","ricky","rocky","daniel",
};

    public static string[] bitbrains = new string[] { "bitlers","seven hundred megabyters","submariners","one bit per second errs","bit brain nano terrorists",
                "no wayers","nano dungeoners","bitters","leafers",
            "bravo's racist fistsers","european walking conspirators", "bit brains","bit holes","bit holers",
        "louisiana brain deathers","nano terrorist","redders","bit callers","bit masters","KG Bit"
        
        };
    

        public static string[] bitbrain_s = new string[] { "bitler's","oner's","zeroer's","seven hundred megabyter's","submariner's","one bit per second errs","bit brain nano terrorist's",
                "no wayer's","nano dungeoner's","bitter's","leafer's",
            "bravo's racist fistser's","european walking conspirator's", "bit brain's","bit hole's","bit holer's",
        "louisiana brain deather's","nano terrorist's","redder's","bit caller's","billy bits","bit master's"
        
        };


        public static string[] bit_modify = new string[] { "seven hundred megabytes","submarine","one bit per second","bit brain",
                "no way","rebitted","bit","leaf",
            "bravo's racist fists","one","zero","red","bullbit","european walking conspiracy"};
            

        public static string[] bit_modify_y = new string[] { "seven hundred megabytes","submarine","one bit per second","bit brain nano terrorist",
               "no way","rebitted","nano dungeon","bit","leaf",
            "bravo's racist fists","european walking conspiracy","red","one","zero","bullbit","rebitted"};


        public static string[] bit_modifies = new string[] { "seven hundred megabytes","submarines","one bit per seconds","bit brain nano terrorists",
                "no ways","rebits","nano dungeons","bits","leafs",
            "bravo's racist fists","european walking conspiracies","reds","ones","zeroes"};

        public static string[] bit_modified = new string[] { "seven hundred megabyted","submarined","one bit per seconded","bit brain nano terroristed",
                "no wayed","rebitted","nano dungeoned","bitted","leafed",
            "bravo's racist fistsed","european walking conspired","redded","oned","zeroed"};


        public static string[] bit_modifying = new string[] { "seven hundred megabyting","submarine in","one bit per seconding","bit brain nano terroristing",
                "no waying","rebitting","nano dungeoning","bitting",
            "bravo's racist fistsing","european walking conspiracy-ing","redding","oneing","zeroing","leafing","bitting"};


        public static string[] nano_modifies = new string[] { "Gold Pyramids","G. Therms", "E one point zero ees","aspercreams","twice the effect with out the meaning","shadow idea",
                "pure senses","perfect thought disorders","far thoughts","shadow ideas","green pyramidses","you cause yous","shadow coincidences",
                "not finished i have to laughs","bit brains","louisiana brain deaths","seven hundred megabytes","submarines","one bit per seconds","bit brain nano terrorists",
                "no ways","2 6 9 chess A dees","evacuate green lines","rebits","bits","leafs",
            "things not things","long way outs","james knows the effect with out knowing the meanings",
            "far thoughts","bossys","talk is nices","end conversation bores mes","scorpions","draculas","you cause yous",
            "green even when he's reds","bravo's racist fists","european walking conspiracies","bossies","reds","greens","ones","zeroes","black when blacks","bitbrain heaters"

            };
        public static string[] nano_modified = new string[] {  "Gold Pyramided","G. Thermed","E one point zero eed","aspercreamed","twice the effect with out the meaninged","shadow ideaed",
                "pure sensed","perfect thought disordered","far thoughted","shadow ideaed","green pyramidsed","you cause you'ed","shadow coincidenced",
                "not finished i have to laughed","bit brained","louisiana brain deathed","seven hundred megabyted","submarined","one bit per seconded","bit brain nano terroristed",
                "no wayed","2 6 9 chess A deed","evacuate green lined","rebitted","bitted","leafed",
            "things not thingsed","long way outed","james knows the effect with out knowing the meaninged",
            "bossied","talk is niced","end conversation bores me'ed","scorpioned","dracula-ed",
            "green even when he's reded","bravo's racist fisted","european walking conspiracied","redded","greened","oned","zeroed","black when blacked","bitbrain heatered"
            };
        public static string[] nano_modify = new string[] { "Gold Pyramid","G. Therm","bit brain killer","E1 point 0E","nonsense nonsense sense is your ass killed","aspercream",
                "twice the effect with out the meaning","james knows the effect with out knowing the meaning",
                "pure sense","perfect thought disorder","far thought","shadow idea","green pyramids","you cause you","shadow coincidence",
                "not finished i have to laugh","bit brain","louisiana brain death","seven hundred megabytes","submarine","one bit per second","bit brain nano terrorist",
                "no way","2 6 9 chess A dee","evacuate green line","rebitted","bit","leafs",
            "things not things","long way out","bossy","talk is nice","scorpion","dracula","green even when he's red","bravo's racist fists","black when black",
            "european walking conspiracy","red","green","bitbrain heater"};

        public static string[] nano_modify_y = new string[] { "Gold Pyramid","G. Therm","bit brain killer","E1 point 0E","non sense non sense sense is your ass killed","aspercream",
                "twice the effect with out the meaning","james knows the effect with out knowing the meaning",
                "pure sense","perfect thought disorder","far thought","shadow idea","green pyramids","you cause you","shadow coincidence",
                "not finished i have to laugh","bit brain","louisiana brain death","seven hundred megabytes","submarine","one bit per second","bit brain nano terrorist",
                "no way","2 6 9 chess A dee","evacuate green line","rebitted","bit","leaf",
            "things not things","long way out","bossy","talk is nice","scorpion","dracula","green even when he's red","bravo's racist fists",
            "european walking conspiracy","red","green","one","zero","black when black"};

        public static string[] nano_modifying = new string[] { "Gold Pyramiding","G. Therming","bit brain killering","E one point zero E","non sense non sense sense is your ass killed-ing","aspercreaming",
                "twice the effect with out the meaning","james knows the effect with out knowing the meaning",
                "pure sensing","perfect thought disordering","far thoughting","shadow ideaing","green pyramidsing","you cause you","shadow coincidencing",
                "not finished i have to laughing","bit braining","louisiana brain deathing","seven hundred megabyting","submarine in","one bit per seconding","bit brain nano terroristing",
                "no waying","2 6 9 chess A deeing","evacuate green lining","rebitting","bitting","leafing",
            "things not thingsing","long way outting","talk is nicing","scorpioning","dracula-ing","green even when he's redding","bravo's racist fistsing",
            "european walking conspiracy-ing","bossying","redding","greening","oneing","zeroing"};


        public static string[] time = new string[] { "night", "day", "week", "month", "year", "time", "age", "era", "millennium", "century", "aeon", "eternity","Hyborian Age" };
        public static string[] times = new string[] { "nights", "days", "weeks", "months", "years", "times", "ages", "eras", "millennia", "centuries", "aeons", "eternities" };
        public static string[] modify_time_place = new string[] { "night mare", "merry", "new", "old", "ancient", "transcendental", "brave new" };
        public static string[] in_time = new string[] { "in", "during", "throughout" };
        public static string get_time_or_place_or_neither()
        {
            set_time = false;
            set_place = false;
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(get_time());
                if (RandomNumber.Rand4(2) == 0)
                {
                    str.Append(get_place());
                }
            }
            else
            {
                if (RandomNumber.Rand4(2) == 0)
                {
                    str.Append(get_place());
                }
                str.Append(get_time());
            }            
            return str.ToString();
        }
        public static bool set_reason = false;
        public static string get_reason()
        {
            if (set_reason == true)
            {
                //return "";
            }
            set_reason = true;
            string str = "{because|cuz} ";
            str += pick(reason, "reason");
            
            return str;

        }
        public static string[] reason = new string[] { "[get_aspercream] is [get_far_thought]", "[get_aspercream] {marries|dates|loves} a [get_far_thought] {girl|woman}","[get_aspercream] {does|thinks|has|was|likes|loves|hates [get_bitbrains] about} [get_far_thought] {things|stuff|shit}","[get_aspercream] made a [get_far_thought] planet" };
        public static string get_time()
        {
            StringBuilder str = new StringBuilder();
            //if (set_time == true) { return ""; }
            set_time = true;
            /*
            
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(pick(new string[] { "when", "whenever", "sometime when", "anytime", "everytime" }, "when"));
                str.Append(pick(reason, "reason"));
                return str.ToString();
            }
            else
            {
                if (RandomNumber.Rand4(times.Length + 2) == 0) { return "{all the damned time|somewhere in time} "; }
                //if (RandomNumber.Rand4(times.Length + 2) == 0) { return "once in " + get_bitbrain_s() + "life time "; }
                if (RandomNumber.Rand4(in_time.Length) == 0)
                {
                    set_place = true;
                    str.Append("somewhere in ");
                }
                else
                {
                    str.Append(pick(in_time, "in_time"));
                }
            }
            */
            str.Append(pick(in_time, "in_time"));
            str.Append(get_time_no_in());
            return str.ToString();
        }
        public static string get_time_no_in()
        {
            set_time = true;
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append((RandomNumber.Rand4(2) == 0) ? "the " + get_time_no_inthe() : get_a(modifier_time_place() + get_far_thought_list() + pick(time, "time")));
            }
            else
            {
                str.Append("the " + modifier_time_place() + (RandomNumber.Rand4(2) == 0 ? pick(times, "times") : pick(time, "time")) + "of " + get_far_thought_list());
            }
            return str.ToString();
        }
        public static string get_time_no_inthe()
        {
            set_time = true;
            StringBuilder str = new StringBuilder();
            str.Append(get_far_thought_list() + (RandomNumber.Rand4(2) == 0 ? pick(times, "times") : pick(time, "time")));
            return str.ToString();
        }
        public static string geta_time_no_inthe()
        {
            set_time = true;
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(get_far_thought_list() + pick(times, "times"));
            }
            else
            {
                str.Append(get_a(get_far_thought_list()) + pick(time, "time"));
            }
            return str.ToString();
        }
        public static string modifier_time_place()
        {
            StringBuilder str = new StringBuilder();
            if (set_modify_time_place == true) { return str.ToString(); }
            set_modify_time_place = true;
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(pick(modify_time_place, "modify_time_place"));
            }
            return str.ToString();
        }
        public static string[] placesa = new string[] {"hotel","palace","kingdom","igloo",
                "moon base","mars colony","star destroyer","nano utopia","u f o","submarine base","ballistic missile site","nuclear submarine","restaurant","space station","cd manufacturering plant",
        "submarine making facility","harem","star port","galaxy","solar system","chilis restaurant","outback restaurant","ruth chris restaurant","dragos restaurant","hilton hotel","Hyatt hotel", "Peppers restaurant",
        "buffalo wild wings restaurant","walmart","rouses","books-a-million","place","home","house","apartment","room","monastery","egyptian pyramid",
        "court room","jail","penitentiary","romulan warbird","bull bit farm","presidential suite","castle","village","town","city","ghetto","hood","hide out","state","ice castle","magical kingdom",
        "sanctuary","recording studio","music video","movie","court testimony","destroyer","P8-A submarine hunter","bedroom","living room","bathroom mirror","kitchen","garage",
        "summer camp","reality","nano dungeon","pre nano simulation","class room",
        "college","lecture hall","elementary school","neighborhood","mansion","police station","mall","yacht","museum","limousine","private jet",
        "jacuzzi","pool","garden","bath tub","shower","hotel room","bath room","missile boat","church","church of [get_aspercream]","shrine","temple","gas station","apartment building",
            "movie theatre",
        "library","supermarket","train station","party","weed circle","plantation","voice conspiracy",
        "styling contest","matrix","prom","wedding","office","lab","basement","attic","trailer park","trailer","university","catholic school","convent","cabin","park","parking lot","brothel",
            "strip club","styling championship",
        "championship","hell","heaven","paradise","mountain","mountain hall","fountain of youth","afterlife","coincidence","republic","white house","worm hole","world trade center","circle of hell","jail cell","dream",
            "fantasy","utopia","country","world","conspiracy","dining room","cop car","closet","bed","living room","kitchen","bath tub","park","school bus","map contest","desert","yacht","porn movie","soap opera","back yard bar b q",
            "mosh bit","concert","stadium","car","truck","s u v","taxi cab","mini van","van","restaurant","bar","submarine","air craft carrier","train","crack house","meth lab","wal mart","street","block",
            "neighborhood","[get_bitbrains] delusion","society","fun house","[get_aspercream_s] fun house","covered dinner","candle light dinner","romantic dinner","dance floor","recording studio","strip club","club","shadow jail"

        };

        public static string[] placesthe = new string[] {"nano dungeon of doom","wild wild nano dungeon of doom","starship enterprise",
                "millennium falcon","white house","united nations building","chateau de versailles","emerald thai restaurant","southland mall","mall of america",
                "eiffel tower","taj mahal","big apple","kremlin","neuschwanstein castle","vatican","earth",
        "dinosaur park","streets","nano terrorists head quarters","bitbrain killers' head quarters","west side","east side","nanopol's headquarters","styling contest","catacombs","middle of nowhere","gates of tomorrow",
        "mountain","mountain hall","city of the {dead,mind raped}","dimension","realm","spirit world","reality","shadow world","shadow realm","shadow dimension","shadow reality","yard","back yard","stars","bronx",
        "chicago mob","crips","bloods","c i a","k g b","population","police association","navy seals","marine core","army","air force","ghost busters","counter nano terrorist strike force","pentagon",
        "white house","vatican","Emerald City","Shire","Godric's Hollow","Jurassic Park","Dragonstone","Springfield","Azeroth","Camelot","thieves guild","black hand","Crematoria","Endor","Fantasia",
        "Jumanji","Krull","Spirit Realm","Drangleic","Kingdom of Daventry","Mushroom Kingdom","Nirn","Termina","Twilight Realm","Hyrule"
        };

        public static string[] places = new string[] { "land", "country", "county", "kcsr","america","europe","north america","south america","russia","china","japan","feudal japan","middle earth",
            "los angeles","chicago","dallas","new york","rome","paris","london","moscow","beijing","south central Los Angeles","new orleans","houma","louisiana","tampa","central park","atlantis","camelot",
        "el dorado","shangri-la","mount olympus","zion","Transylvania","nano auschwitz","harlem","brooklyn","{cheyenne's {mom's|dad's|parent's}|aliza's {mom's|dad's|parent's}} [get_far_thought] {house|trailer}",
        "[get_bitbrains] head","{[get_bitbrain_s],[get_aspercream_s]} dream","sniper school","pre school","grade school","college","Hogwarts School of Witchcraft and Wizardry","Xavier's Academy",
        "Asgard","Narnia","Hogsmeade","Rivendell","Diagon Alley","King's Landing","Pandora","Lilliput","Panem","Shadowrealm","shadow world","Tamriel","Atlantis","El Dorado"
        };

        public static string[] onplaces = new string[] { "Executor Star Destroyer", "golden state bridge", "wall of china", "History Channel", "Travel Channel", "funny farm", "bit farm", "pirate ship", "stage", "peter's street", "east side", "west side", "south side" };

        public static string[] onaplaces = new string[] { "death star", "planet", "seven forty seven", "cargo ship", "nuclear submarine", "star ship", "school bus", "grey hound bus", "stage", "block", "sail boat","aircraft carrier",
        "tv channel","dyson sphere","ferris wheel"
        };

        public static string[] atplaces = new string[] { "angel falls", "egyptian pyramids", "end of a rainbow", "nano terrorists war crimes tribunal", "orgy", "nano center", "styling contest", "dinner table", "wedding", "prom", "white house", "pentagon", "kitchen sink", "dinner table", "air port", };

        public static string[] whereplaces = new string[] { "[get_aspercream] does [get_far_thought] {shit|stuff|things}", "[get_aspercream] [get_whatthings]","[get_aspercream] [get_whatthings] with [get_far_thought] {women|chicks|girls}",
        
        };
        public static string[] whatthings = new string[] { "rides","balls","dances","slangs drugs","throws them thangs","gang bangs",
            "becomes a wizard","does cartel work","raps","breaks [get_far_thought] hearts",
        "sees death around the corner","is heavy in the [get_far_thought] game","is in deep","has all eyes on him","treats his girl just like daddy",
        "raps","free styles","figures out the [get_far_thought] game","brings the pain","invades a planet",
        "stops hearts","was trained as a boss player","laced the game with [get_far_thought] insight","has a [get_far_thought] war mentality",
        "masters the art of war",

        };
        public static string[] bitbrainthings = new string[] { "falls on it's face", "gets cock blocked", "hates {everything,people}", "crashes it's [get_bit_modify] car","gets smacked in it's face","gets blasted","O Dees on dope",
            "backs up it's brain to a CD","pretends to know kung fu","gets lit on fire","gets stabbed","gets ebola","flies into a black hole","lies about how long it's nanodungeon gonna last",
        "makes [get_aspercream] think he knows [get_bit_modify] hobies all his life"};
        public static string[] forthings = new string[] { "money", "bitches", "chicks", "women", "fame", "glory", "revenge", "triumph", "victory", "{black,dark} {love,passion,desires,magic}" };

        public static string get_forthings()
        {
            return "for [get_far_thought] " + pick(forthings, "forthings");
        }

        public static string get_whatthings()
        {
            return pick(whatthings, "whatthings");
        }
        public static string get_bitbrainthings()
        {
            return pick(bitbrainthings, "bitbrainthings");
        }
        public static int get_case(int[] arr)
        {
            int t = RandomNumber.Rand4(arr.Sum());
            int i = 0;
            int x = arr[i];
            while (t >= x)
            {
                i++;
                x += arr[i];
            }
            return i;
        }
        public static string get_place()
        {

            StringBuilder str = new StringBuilder();
            if (set_place == true) { return str.ToString(); }
            set_place = true;
            int[] t = { placesa.Length, placesthe.Length, places.Length, onplaces.Length, onaplaces.Length, atplaces.Length, whereplaces.Length, nanodungeon_of_doom.Length };
            switch (get_case(t))
            {
                case 5:
                    str.Append("at the " + modifier_time_place() + pick(far_thought_list, "far_thought_list") + pick(atplaces, "atplaces"));
                    break;
                case 3:
                    str.Append("on the " + modifier_time_place() + pick(far_thought_list, "far_thought_list") + pick(onplaces, "onplaces"));
                    break;
                case 0:
                    str.Append("in " + get_a((modifier_time_place() + pick(far_thought_list, "far_thought_list") + pick(placesa, "placesa"))));
                    break;
                case 1:
                    str.Append("in the " + modifier_time_place() + pick(far_thought_list, "far_thought_list") + pick(placesthe, "placesthe"));
                    break;
                case 2:
                    str.Append("in " + pick(far_thought_list, "far_thought_list") + pick(places, "places"));
                    break;
                case 4:
                    str.Append("on " + get_a(pick(far_thought_list, "far_thought_list")) + pick(onaplaces, "onaplaces"));
                    break;
                case 6:
                    str.Append(pick(new string[] { "where", "somewhere", "anywhere", "everywhere" }, "where"));
                    str.Append(pick(whereplaces, "whereplaces"));
                    break;
                case 7:
                    str.Append("in the " + get_nano_modify() + get_nanodungeon_of_doom());
                    break;
            }
            return str.ToString();
        }
        public static string get_place_no_in()
        {
            set_place = true;
            StringBuilder str = new StringBuilder();
            int[] t = { placesa.Length, placesthe.Length, places.Length, onplaces.Length, onaplaces.Length, atplaces.Length, 1,nanodungeon_of_doom.Length };
            switch (get_case(t))
            {
                case 5:
                    str.Append("the " + modifier_time_place() + pick(nano_modify, "nano_modify") + pick(atplaces, "atplaces"));
                    break;
                case 3:
                    str.Append("the " + modifier_time_place() + pick(nano_modify, "nano_modify") + pick(onplaces, "onplaces"));
                    break;
                case 0:
                    str.Append(get_a((modifier_time_place() + pick(nano_modify, "nano_modify") + pick(placesa, "placesa"))));
                    break;
                case 1:
                    str.Append("the " + modifier_time_place() + pick(nano_modify, "nano_modify") + pick(placesthe, "placesthe"));
                    break;
                case 2:
                    str.Append(pick(nano_modify, "nano_modify") + pick(places, "places"));
                    break;
                case 4:
                    str.Append(get_a(pick(onaplaces, "onaplaces")));
                    break;
                case 6:
                    str.Append(pick(new string[] { "where", "somewhere", "anywhere", "everywhere" }, "where"));
                    str.Append(pick(whereplaces, "whereplaces"));
                    break;
                case 7:
                    str.Append("in the " + get_nano_modify() + get_nanodungeon_of_doom());
                    break;
            }
            return str.ToString();
        }
        public static string athingplaceortime()
        {
            StringBuilder str = new StringBuilder();
            int t;
            do
            {
                t = RandomNumber.Rand4(3);
                if (set_place == true && t == 1)
                {
                    t = -1;
                }
                if (set_time == true && t == 2)
                {
                    t = -1;
                }
            } while (t == -1);
            switch (t)
            {
                case 0:
                    str.Append(thing());
                    break;
                case 1:
                    str.Append(get_place_no_in());
                    break;
                case 2:
                    str.Append(get_time_no_in());
                    break;
            }
            return str.ToString();
        }

        public static string get_a_thing()
        {
            return get_a_nano_modify() + pick(athing, "athing");
        }
        public static string get_bitbrain_thing()
        {
            return get_a_bit_modify() + pick(athing, "athing");
        }

        public static string get_power()
        {
            if (RandomNumber.Rand4(3) == 0)
            {
                return get_powerthing();
            }
            if (RandomNumber.Rand4(3) == 0)
            {
                return get_aspercream();
            }
            return get_powerbeing();
        }
        public static string get_powerthing()
        {
            return get_a(get_a_far_thought() + pick(powerthing, "powerthing"));
        }
        public static string get_powerbeing()
        {
            return get_a_far_thought() + pick(powerbeing, "powerbeing");
        }

        public static string[] powerthing = new string[] {
            "submarine","u boat","f 22","stealth bomber","sky scraper","house","home","bus","school bus","b 52","minute man missile","icbm","bank","mob","free candy van","police car","fbi van","store",
            "mall","school","college","factory","abandonned {truck|submarine|car|building}","conspiracy","gang","cartel","missile factory","cd manufacturing plant","submarine making facility",
            "space station","u f o","space ship","star destroyer","death star","x wing","corporation","group","trailer","apartment","duplex","g ride","weed circle","city","state","country",
            "prison","counter nanoterrorist strike force head quarters","romulan warbird","star ship enterprise","planet","solar system","galaxy","black hole computer","lottery company",
            "catholic school","nano utopia","utopia","paradise"
        };
        public static string[] powerbeing = new string[]
        {
            "dragon","grandmother","grandfather","father","mother","son","daughter","sister","brother","cop","f b i agent","c i a agent","troll","counter nanoterrorist strike force agent","cd manufacturing planet {c e o,worker}",
            "submarine building facility worker","submarine captain","nano prisoner","[get_bitbrain] killer"
        };
        public static string[] athing = new string[] {"dinner","egg","seven forty seven","blunt","ufo",
                "oyster","joint","40 ounce","glass of rum","glass of scotch","jar of grey poupon","tie fighter","x-wing","beer","coffee","coffee table","poker game","gang","drug cartel",
                "submarine","college exam","knife","bank account","check","yacht","anaconda","lion","tiger","bear","polar bear","wolf","cobra","guillotine","eletric chair","cyanide pill","baseball bat",
                "jacuzzi","pool","garden","color combination light sabre","bath tub","shower","limousine","private jet","cigar","rose","machete","scorpion","snake","law of physics",
                "computer program","cat","dog","bottle of champagne","glass of champagne","cadillac","ferarri","lamborghini","bugatti veyron","number theory","computational theory","physics theory",
            "social theory","information theory",
                "T-Rex","velociraptor","allosaurus","mountain of gold","christmas tree","snow man","falling star","comet","dinosaur","crocodile","alien","bag of marijuana","nano bot","sea of madness",
                "car","g-ride","bk-ride","grabber blue ford mustang","suv","hooptie","64 impala","time machine","g ride","bk ride","circle of life","circle of hell","lie","fact","story","idea",
                "reason","style","butterfly effect","justification","justice","camp fire","sentence","paragraph","verse","judgement","election","ring","watch","vision","television","{smart,tele} phone",
                "computer","operating system","video game","song","box","hard drive","yoyo","bike","skate board","trampoline","pool table","washer","drier","refrigerator","cooler master nepton",
                "car engine","truck engine","car horn","helicopter","airplane","air conditioner","air conditioning vent","heater","water heater","myth","superstition","elixir","exlixir of life","unicorn horn",
                "magic lamp","throne","dragon","troll","CD","sands of time","language","sword","spear","club","set of armor","bow","sling shot","symmetry","asymmetry","argument","conspiracy",
                "rule of the game","rule of engagement","speaker","computer speaker","A I","noise","electric chair","chair","sofa","soda","candy bar","quasar","black hole","star","nanobot","technological singularity",
                "army","navy","platoon","harpie","mermaid","oath of loyalty","cyborg","robot","matrioshka brain","jupiter brain","answering machine message","answering machine","telephone booth","pager","nintendo","commodore 64",
                "sega master system","heating vent","tv","ring of power","holy grail","lost ark","jewel","gem","diamond","hope diamond","worm hole",
                "world trade center","bomb","warp drive","teleporter","torpedo","nuclear submarine","missile boat","boomer","aircraft carrier","destroyer","depth charge","eternity","hell","heaven",
                "dynasty","empire","royal seal","dating service","realm","bong","dream","world","{black,[get_bit_modify] color combination} blood of the [get_nanodungeon_of_doom]",
                "burning blade","magic potion","wedding","graduation","secret society","emotion","sentiment","memory","prediction","relationship","love affair",
                "one night stand","marriage","life","vacation","honey moon","marriage proposal","sin","blood line","business","corporation","government",
                "[get_bit_modify] color combination blood of the [get_nanodungeon_of_doom]","abandoned truck","abandoned submarine","tape","luck","destiny","Fate","karma",


            };
        public static string thing()
        {

            string[] afarperson = new string[] { "jedi knight", "sith lord", "nano prisoner" };
            string[] aperson = new string[] { "pedestrian", "driver","truck driver", "starship enterprise officer","man","woman","child","girl","boy","post man","tax man","computer programmer",
                "journalist","traffic cop","husband and wife","college student","lawyer","judge","wage slave","valet","alien","monster"
            };
            string[] abitperson = new string[] { "crack head", "communist", "nano whore", "enemy", "meth head", "junkie", "crack whore" };


            string[] thething = new string[] { "starship enterprise", "millennium falcon", "book of the mind raped","styling contest","nano game","U.S. government",
                "C I A","N S A","F B I","marine corps","N Y P D","L A P D","hope diamond","houma police department","association","club","organization","government","clan","group","think tank","news paper",
            "truth","peace","war","storm","calm","sacrificial lamb","logic system"};

            string[] bitbrainthing = new string[] { "face per cream", "car", "jail cell", "cd", "nano dungeon", "obituary", "ambition",
                "show tech shot","trunk full of [get_bit_modify] bullshit","sickle cell anemia","trophy wife","dildo","teddy bear","diaper","{thought|brain|personality} disorder",
                "bull bit","drug trip","diapers","bit hole","communist mind conspiracy","nanoterrorist mind conspiracy"
            };

            string[] bitchthing = new string[] { "purse", "tampon", "panties", "pussy", "aspercream", "titties", "silk panties", "g-string", "bra", "wedding dress", "lips", "husband", "boyfriend", "prom dress", "pimply face per cream" };

            string[] notbitbrainthing = new string[] { "fist", "face per cream", "g-ride", "bk-ride", "heater", "cd", "free style", "rap", "P8-A sub hunter", "book of the mind raped", "mafia", "gang",
                "F-22","F-16","F-15","B2 Stealth Bomber","foot","eyes","family","marriage","job","circle of life","painting","squad","cash stacks","life","computer",
            "jet ski","poem","song","talisman","good luck charm","watch","ring","ambition","honor","trophy","best friend","father","mother","sister","brother",
            "prophecy","destiny","fate","act of war","declaration of war","cease fire","peace treaty","book","movie","movie plot","autobiography",
            "personality","joke","comment","statement","quip","vow","constitution","manifesto","law","order","magic chest"
            };

            string[] bitbrainkillerthing = new string[] { "tuxedo", "wife", "girl friend", "marbles", "style", "trophy wife", "geography lessons", "map","military style judgement",
                "secretary style judgement","salad dressing",
                "kilos of cocaine","yacht","hotel","country","planet","galaxy","nano utopia","block","neighborhood","nuclear submarine","best friend","face per cream",
                "prophecy","destiny","fate","style judgement","mind",
            "flesh","heart","life","crown","sceptre","chariot","treasure","treasure room","bit hole","passion","honor","bravery","loyalty","character","team","family","love",
                "game","rap","free style","throne","dynasty","face","empire","love slave","circle","ambition","style","voice in his head","corporation","trust","foundation","conspiracy",


            };

            StringBuilder str = new StringBuilder();

            switch (RandomNumber.Rand4(8))
            {
                case 0:
                    str.Append(get_a(get_aspercream_mofos(bitch_s) + get_far_thought_list() + pick(thething.Concat(notbitbrainthing).Concat(bitchthing).Concat(athing).Concat(gun).Concat(guns).Concat(food_list).Concat(foods_list).ToArray(), "thing case 3")));
                    break;
                case 1:
                    str.Append("the " + get_nano_modify() + pick(thething, "thething"));
                    break;
                case 2:
                    str.Append(get_a(pick(nano_modify, "nano_modify")) + pick(athing.Concat(food_list).Concat(notbitbrainthing).Concat(food_list).Concat(foods_list).Concat(guns).Concat(gun).ToArray(), "thing case 2"));
                    break;
                case 3:
                    str.Append(get_a(get_bitbrain_mofo(bitbrain_mofo_s)) + get_bit_modify() + pick(bitbrainthing, "bitbrainthing"));
                    break;
                case 4:
                    str.Append(get_aspercream_s() + get_far_thought_list() + pick(thething.Concat(notbitbrainthing).ToArray().Concat(bitbrainkillerthing).ToArray().Concat(athing).ToArray().Concat(gun).ToArray().Concat(guns).ToArray().Concat(food_list).ToArray().Concat(foods_list).ToArray().ToArray(), "thing case 4"));
                    break;
                case 5:
                    str.Append(get_a(pick(far_thought_list, "far_thought_list")) + pick(afarperson, "afarperson"));
                    break;
                case 6:
                    str.Append(get_a(get_bit_modify()) + pick(abitperson, "abitperson"));
                    break;
                case 7:
                    str.Append(get_a(get_nano_modify()) + pick(aperson, "aperson"));
                    break;
            }
            return str.ToString();
        }
        public static string get_animal_or_animals()
        {
            if (RandomNumber.Rand4(2) == 0) { return get_animal(); } else { return get_animals(); }
        }
        public static string get_animal()
        {
            return get_a_nano_modify() + pick(animal, "animal");
        }
        public static string get_animals()
        {
            return get_nano_modify() + pick(animals, "animals");
        }
        public static string get_a_far_thought()
        {
            return get_a(get_far_thought_list());
        }

        public static string[] animal = new string[] { "shark", "velociraptor", "a T-Rex", "Allosaurus", "wolf", "bear", "polar bear", "lion", "crocodile", "tiger", "pit bull", "killer whale" };
        public static string[] animals = new string[] { "sharks", "velociraptors", "a T-Rexes", "Allosauruses", "wolves", "bears", "polar bears", "lions", "piranhas", "crocodiles", "tigers", "pit bulls", "killer whales" };

        public delegate string test();

        public static string get_nanodungeon_of_doom()
        {            
            if (RandomNumber.Rand4(2) == 0)
            {
                return "nano dungeon of " + pick(nanodungeon_of_doom, "nanodungeonofdoom");
            }
            string str = pick(nanodungeon_of_doom, "nanodungeon of doom");
            string str2;
            int i = 0;
            do
            {
                str2 = pick(nanodungeon_of_doom, "nanodungeon of doom");
                i++;
            } while (str == str2 && i < 5);
            return "nanodungeon of " + str + " and " + str2;

        }
        public static string[] nanodungeon_of_doom = new string[]
        {
            "doom{s}","miser{y|ies}","suffering{s}","disappointment{s}","regret{s}","wasted life","hard ship{s}","affliction{s}",
            
            "torment{s}","torture{s}","agon{y|ies}","pain{s}","insanit{y|ies}","{lost|false|no} hope{s}","deprivation{s}",
            "grief{s}","desolation{s}","sadness","sorrow","melancholia","melancholy","bull bit"

        };

        public static string get_old_bitbrain()
        {
            string[] girls = { "jackie", "marcy", "rosa" };
            return pick(girls, "girls");
        }

        public static string link()
        {
            return pick(linkArray,"linkArray");
        }
        public static Dictionary<string, test> dels = new Dictionary<string, test>()
        {
            {"[link]", new test(link) },          
            {"[get_power]",new test(get_power)},
            {"[get_forthings]",new test(get_forthings) },
            {"[get_bitbrainthings]",new test(get_bitbrainthings) },
            {"[get_whatthings]",new test(get_whatthings) },
            {"[get_mental]",new test(get_mental) },
            {"[get_old_bitbrain]",new test(get_old_bitbrain) },
            {"[get_nanodungeon_of_doom]",new test(get_nanodungeon_of_doom) },
            {"[get_no_a_aspercream]",new test(get_no_a_aspercream) },
            {"[get_aspercreams]",new test(get_aspercreams) },
            {"[get_a_aspercream",new test(get_a_aspercream)},
            {"[get_a_far_thought]",new test(get_a_far_thought) },
            {"[get_a_thing]",new test(get_a_thing) },
            {"[get_bitbrain]",new test(get_bitbrain)},
            {"[get_bitbrains]",new test(get_bitbrains)},
            {"[get_bitbrain_s]",new test(get_bitbrain_s)},
            {"[get_no_a_bitbrain]",new test(get_no_a_bitbrain)},
            {"[athingplaceortime]",new test(athingplaceortime)},
            {"[get_aspercream_bitch]",new test(get_aspercream_bitch)},
            {"[get_aspercream]",new test(get_aspercream)},
            {"[get_aspercreaming]",new test(get_aspercreaming)},
            {"[get_aspercream_s]",new test(get_aspercream_s)},
            {"[get_aspercream_any]",new test(get_aspercream_any)},
            {"[get_aspercream_mofos_or_bitches]",new test(get_aspercream_mofos_or_bitches)},
            {"[get_aspercream_bitch_or_bitches]",new test(get_aspercream_bitch_or_bitches)},
            {"[get_aspercream_or_aspercreams]",new test(get_aspercream_or_aspercreams)},
            {"[get_a_bitbrain_or_bitbrains]",new test(get_a_bitbrain_or_bitbrains)},
            {"[get_handgun]",new test(get_handgun)},
            {"[get_handguns]",new test(get_handguns)},
            {"[get_gun]",new test(get_gun)},
            {"[get_guns]",new test(get_guns)},
            {"[get_bit_modify]",new test(get_bit_modify)},
            {"[get_a_bit_modify]",new test(get_a_bit_modify)},
            {"[get_bit_modify_y]",new test(get_bit_modify_y)},
            {"[get_bit_modifies]",new test(get_bit_modifies)},
            {"[get_bit_modifying]",new test(get_bit_modifying)},
            {"[get_bit_modified]",new test(get_bit_modified)},
            {"[get_bit]",new test(get_bit_modify)},
            {"[get_a_bit]",new test(get_a_bit_modify)},
            {"[get_bitty]",new test(get_bit_modify_y)},
            {"[get_bits]",new test(get_bit_modifies)},
            {"[get_bitting]",new test(get_bit_modifying)},
            {"[get_bitted]",new test(get_bit_modified)},
            {"[get_food_list]",new test(get_food_list)},
            {"[get_foods_list]",new test(get_food_lists)},
            {"[get_bitbrain_bitches]",new test(get_bitbrain_bitches)},
            {"[get_a_nano_modify]",new test(get_a_nano_modify)},
            {"[get_nano_modify]",new test(get_nano_modify)},
            {"[get_nano_modify_y]",new test(get_nano_modify_y)},
            {"[get_nano_modifies]",new test(get_nano_modifies)},
            {"[get_nano_modified]",new test(get_nano_modified)},
            {"[get_nano_modifying]",new test(get_nano_modifying)},
            {"[get_a_nan]",new test(get_a_nano_modify)},
            {"[get_nan]",new test(get_nano_modify)},
            {"[get_nany]",new test(get_nano_modify_y)},
            {"[get_nanies]",new test(get_nano_modifies)},
            {"[get_naned]",new test(get_nano_modified)},
            {"[get_naning]",new test(get_nano_modifying)},
            {"[get_time_no_in]",new test(get_time_no_in)},
            {"[geta_time_no_inthe]",new test(geta_time_no_inthe)},
            {"[get_time]",new test(get_time)},
            {"[get_aspercream_bitches]",new test(get_aspercream_bitches)},
            {"[get_place_no_in]",new test(get_place_no_in)},
            {"[get_place]",new test(get_place)},
            {"[get_far_thought]",new test(get_far_thought_list)},
            {"[get_far]",new test(get_far_thought_list)},
            {"[get_james_thought]",new test(get_james_thought_list)},
            {"[get_bit_face]",new test(get_bit_face)},
            {"[get_bitbrain_bitch_or_bitches]",new test(get_bitbrain_bitch_or_bitches)},
            {"[get_a_bitbrain_bitch]",new test(get_a_bitbrain_bitch)},
            {"[get_animal_or_animals]",new test(get_animal_or_animals)},
            {"[get_bitbrainmammy]",new test(get_bitbrainmammy)},
            {"[get_bitbrain_thing]",new test(get_bitbrain_thing) },
            {"[get_time_or_place_or_neither]",new test(get_time_or_place_or_neither) }
        };
        
        public static string[] bitbrainmammy = new string[] { "a judge", "a police officer", "a F.B.I. Agent", "the president", "their mammies" };
        public static string get_bitbrainmammy()
        {
            return pick(bitbrainmammy, "bitbrainmammy");
        }

        public static Boolean foundone = false;

        public static string replace_func(string str)
        {
            Replace_func_worker(ref str);
            string str2 = "";
            char LastChar = 'a';
            for (int i = 0; i < str.Length; i++)
            {
                if (i > 0 && LastChar == ' ')
                {
                    if (str[i] == ' ')
                    {
                        continue;
                    }
                }
                str2 += str[i];
                LastChar = str[i];
                continue;
            }
            return str2;
        }

        public static Dictionary<int, string> oldPicks = new Dictionary<int, string>();
        public static void Replace_func_worker(ref string str)
        {
            bool recurse = false;
            ChooseOption(ref str);
            FindDels(ref str, ref recurse);
            ReplaceToken(ref str);
            if (recurse)
            {
                Replace_func_worker(ref str);
            }            
        }

        private static void ReplaceToken(ref string str)
        {
            foreach (int i in oldPicks.Keys)
            {
                string replace = "%" + i.ToString();
                if (str.Contains(replace))
                {
                    str = str.Replace(replace, oldPicks[i]);
                }
            }            
        }

        private static void ChooseOption(ref string str)
        {
            while (true)
            {
                int FirstClose = str.IndexOf("}");
                if (FirstClose == -1)
                {
                    break;
                }
                int LastOpen = 0;
                for (int i = 0; i < FirstClose; i++)
                {
                    if (str[i] == '{')
                    {
                        LastOpen = i;
                    }
                }
                string subStr = str.Substring(LastOpen + 1, FirstClose - 1 - LastOpen);
                string[] StrArray = subStr.Split(new char[] { '|' });
                subStr = pick(StrArray, "StrArray");
                subStr = subStr.TrimEnd(' ');
                str = str.Substring(0, LastOpen) + subStr + str.Substring(FirstClose + 1);
            }            
        }

        private static void FindDels(ref string str, ref bool recurse)
        {
            int position = -1;
            foreach (KeyValuePair<string, test> kvp in dels)
            {
                do
                {
                    position = str.IndexOf(kvp.Key);
                    if (position != -1)
                    {
                        recurse = true;
                        string str2 = str.Substring(0, position);
                        string str3 = str.Substring(position + kvp.Key.Length);
                        string pickedWord = dels[kvp.Key].Invoke();
                        pickedWord = replace_func(pickedWord);
                        str3 = GetOldPick(str3, pickedWord);
                        str = str2 + pickedWord + str3;
                    }
                } while (position != -1);
            }           
        }

        private static string GetOldPick(string str3, string pickedWord)
        {
            if (str3.Length >= 2)
            {
                if (str3.StartsWith("="))
                {
                    int i = int.Parse(str3[1].ToString());
                    if (oldPicks.ContainsKey(i))
                    {
                        oldPicks.Remove(i);
                    }
                    oldPicks.Add(i, pickedWord);
                    str3 = str3.Substring(2);
                }
            }
            return str3;
        }

        public struct RandomNumber
        {
            public static byte[] random = new Byte[4];
            public static uint rngReturn;
            public static System.Security.Cryptography.RandomNumberGenerator rng = System.Security.Cryptography.RandomNumberGenerator.Create();

            public static int Rand4(int t, int r = -1)   // t==modulo r==last value, rejected.
            {
                do
                {
                    rng.GetBytes(random);
                    rngReturn ^= System.BitConverter.ToUInt32(random, 0);
                    rngReturn = (rngReturn % (uint)t);
                } while (rngReturn == r);
                return (int)rngReturn;
            }
        }        
    }
}