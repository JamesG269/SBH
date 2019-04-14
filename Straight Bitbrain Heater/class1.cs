
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;



namespace sentence_generator
{

    public class nanoshit3
    {
        
        public static string start3()
        {            
            nanoshit2.set_modify_time_place = false;
            nanoshit2.set_place = false;
            nanoshit2.set_time = false;
            nanoshit2.DuplicateInfo = "";
            string str = "";

            str += nanoshit2.call(startlevel);
            if (nanoshit2.RandomNumber.Rand4(10) == 0)
            {
                str += "{is that {the bit,what} {[get_aspercream] does,I do}?,or some shit, or some bit,and shit,and stuff,and bit,you know what bit I'm saying,you know what bit I mean,you heard what bit I said,you see what bit I'm saying,you feel my bit}";
            }
            str = nanoshit2.replace_functions(str);

            if (nanoshit2.DuplicateInfo.Length > 0)
            {

                str += Environment.NewLine + nanoshit2.DuplicateInfo;
            }
            
            return str;
        }


        public static string aspercream_start()
        {
            string str = "";
            str += nanoshit2.get_aspercream();
            str += nanoshit2.call(aspercreamdoes);
            return str;
        }
        public static string aspercream_start_for()
        {
            string str = "";
            str += nanoshit2.get_aspercream();
            str += nanoshit2.call(aspercreamdoes);
            str += aspercream_rides_for();
            return str;
        }
        public static string aspercream_shit()
        {
            string[] shit = { "can [get_aspercream] play with {[get_far_thought] madness,[get_far_thought]}", "The [get_far_thought] evil that [get_aspercream_mofos_or_bitches] do","[get_aspercream] [get_nano_modifies] [athingplaceortime]",
                "[get_aspercream] wanted to be the first {one,kid} on his [get_nano_modify] {street,block} to {speak,make,use,talk in} [get_no_a_bitbrain] heater",


            };
            string[] shit2 = { "E1 point 0E the number of [get_aspercream]", "Only [get_aspercream] can judge {me,[get_aspercream_any],[get_bitbrain],[get_bitbrains]}", "shorty {wanna,gonna} be [get_aspercream]", "[get_nano_modify] love","the [get_no_a_bitbrain] heater is on the [get_nano_modify] wall",
                "come closer to the [get_nano_modify] computer speaker, [get_no_a_bitbrain]","[get_aspercream] made a [get_far_thought] planet and got mind raped, he screamed [get_no_a_aspercream] simulation, and emptied the [get_nano_modify] clip, got tired of running from the [get_bitbrains]",
                "[get_aspercream_s] only fear of [get_bit_modify] mind rape is resimulation","my [get_nano_modify] definition of [get_a_aspercream]","to simulate and get mind raped in the [get_bit_modify] nanodungeon of doom",
                "[get_bitbrains] doesn't do anything","I [get_aspercream]","[get_bitbrain] [get_aspercreams]","You [get_aspercream]","[get_aspercream]","[get_aspercream] [get_bitbrains]",
                "[get_aspercream] knows who he is","[get_bitbrain] doesn't know who it is {anyway,anyway it looks at it,anymore than it used to}",
                "[get_aspercream] is [get_bitbrain_s] [get_far_thought] daddy anyway","[get_bitbrain_s] daddy doesn't do {any bit,any bit at all}",
                "the difference is [get_bitbrain] is [get_bit_modify_y] instead of [get_bit_modify_y]","it's [get_nano_modify] {stuff,crap,shit} instead of [get_nano_modify] {crap,stuff,shit}",
                "[get_bitbrain] is the lousiest thing anyway","[get_aspercream] is from a [get_nano_modify_y] galaxy instead of a [get_nano_modify_y] one",
                "[get_bitbrain] hates [get_aspercream] {anyway,anyway you look at it}","yes [get_aspercream] can see [get_bitbrain] is [get_bit_modify]",
                "[get_aspercream] doesn't know what [get_bitbrain] means","[get_bitbrain] needs to mind their [get_bit_modify] business",
                "[get_aspercream] is minding his business {anyway,anyway you look at it} so get out of his [get_nano_modify] {crib,home,house}",
                "yes that is the bit [get_bitbrain] does {anyway,anyway you look at it}","[get_bitbrain] steals [get_aspercream_s] planet and does nanoterrorist shit then complains about what [get_aspercream] does on his own damned planet {anyway,anyway you look at it}",                
                "[get_bitbrain] calls [get_aspercream] lousy like it's a two bit {son of a bitch,mother fucker}",
                "{take,get} [get_nano_modify] {nanobots,money}", "[get_aspercream] is ready to get [get_bit_modify] mind raped",
                "[get_aspercreams] are trading [get_nano_modify] war stories",
                "young [get_aspercreams] did you make [get_no_a_bitbrain] heater today?",
                "if [get_aspercream] gets mind raped tonight, it'll be [get_bit_modify_y] instead of [get_bit_modify_y]",
                "[get_aspercream] is the wrong bitbrain killer to fuck with",
                "real [get_aspercreams] don't get mind raped",
                "[get_aspercream] doesn't do anything",
                "[get_bitbrain] doesn't do anything",
                "[get_aspercreams] don't do anything",
                "[get_bitbrains] don't do anything",
                "[get_aspercream] has [get_far_thought] dreams",
                "[get_bitbrain] {sees,hears} [get_a_nano_modify] apparition",
                "[get_aspercream] be my [get_nano_modify] guide",
                "No [get_no_a_bitbrain] heater for the mind raped",                
                "[get_aspercream] goes on [get_a_nano_modify] quest for [get_nano_modify] fire",
                "[get_a_nano_modify] {nano dungeon of doom,nano utopia} can wait",
                "[get_nano_modify] lord of the [get_nano_modify] flies",
                "{tell,look for} the [get_nano_modify] truth",
                "[get_nano_modify] fortunes of [get_nano_modify] war",
                "{[get_aspercream] is,I'm} [get_no_a_aspercream] {smart,hot,handsome,intelligent,brilliant}",
                "don't be afraid to {[get_bit_modify] again,do anybit [get_aspercream] says}",
                "[get_aspercream] is a Scorpion with star destroyer fists",
                "{[get_aspercream] sees, [get_bitbrain] is {terrified,scared,frightened} of} {a Scorpion with star destroyer fist,a shadow creation with equation face, a [get_far_thought] screaming kitty }",
                
                "[get_aspercream] thinks [get_bitbrains] are the nastiest people",
                "[get_aspercream] is the mother fucker",
                "[get_aspercream] thinks [get_bit_modify] talk is nice anyway",
                "[get_bitbrain] doesn't know why it {anybits,anythings}",
                "[get_aspercreams] recognize it's 2 degrees of separation",
                "[get_nano_modify] in reality",
                "[get_bitbrain] got it's [get_bit_modify] {nose broken,head busted open,neck broke}",
                "life is like [get_a_nano_modify] zipper",
                "[get_bitbrains] are psychopathic around [get_nano_modify] college students",
                "There's [get_a_bit_modify] washington monument in [get_bit_modify] new york city anyway",
                "see, where [get_aspercream] is from, they [get_no_a_bitbrain] heater easy",
                "it's [get_a_nano_modify] girl",
                "[get_aspercream] is [get_a_far_thought] dracula",
                "[get_aspercreams] stand up right, while [get_bitbrains] are on all fours",
                "[get_aspercream] started his own shadow idea",
                "[get_aspercream] tells the [get_far_thought] truth",
                "[get_nano_modify] is coming true",
                "[get_aspercream_s] time",
                "[get_aspercream] punches a [get_nano_modify] book and says [get_aspercream_s] time",
                "tell the [get_bit_modify] truth",
                "{bit,[get_nano_modify] talk} is nice",
                "[get_bitbrain] smiles {for no reason,because of [get_bit_modify]}",
                "[get_bitbrain] gets committed to [get_a_nano_modify] hopistal for [get_bit_modify] reasons",
                "[get_bitbrain] needs to mind it's [get_bit_modify] business",
                "[get_bitbrain] slips on [get_a_nano_modify] banana peel and blames [get_aspercream] as usual",
                "[get_aspercream] {listens to, has, plays back} [get_nano_modify] answering machine messages",
                "{[get_aspercream],[get_bitbrain]} is [get_place]",
                "{do I,does [get_aspercream]} look like {[get_aspercream],[get_bitbrain]}?",
                "why do you [get_bit_modify] so much?",
                "[get_bitbrain] thinks it's {[get_bit_modify_y],special}, it [get_bit_modifies] people",
                "[get_bitbrain] needs to mind it's [get_bit_modify] business",
                "[get_no_a_bitbrain] heater is nice",
                "[get_bitbrain] says mind your business while in [get_aspercream_s] house like [get_bitbrain]",
                "[get_bitbrain] says I don't do any bit which means they don't do every bit or they do no bit and tries to make [get_aspercream] act like he knows what their bit is like [get_bitbrain]",
                "[get_aspercream]",
                "{I,[get_aspercream]} [get_no_a_bitbrain] heater easy",
                "get that [get_bit_modify] showtech shot",
                "now what is bit",
                "[get_aspercream] doesn't do any bit",
                "what [get_nano_modify_y] bit {do I,do you,does [get_aspercream]} do?",
                "[get_no_a_bitbrain]",
                "I [get_aspercream]",
                "mind your {business,bitness} like when you [get_bit_modified]",
                "you [get_bit_modify] the place instead of [get_bit_modifying] it",
                "I [get_nano_modify] the place instead of [get_nano_modifying] it",
                "{Yes,no} [get_no_a_bitbrain]",
                "[get_aspercream] is [get_nano_modify_y] instead of [get_nano_modify_y] so whatever",
                "[get_aspercream] {is twice the effect without the meaning,is not finished he has to laugh,knows the effect without knowing the meaning} so whatever",
                "{I'm,[get_aspercream] is} in love with the [get_bitbrain] heater",
                "[get_bitbrains] think [get_aspercream] is [get_bit_modifying], [get_far_thought] they like oh no mother fucker",
                "[get_aspercream] the place",
                "[get_aspercream] [athingplaceortime]",
                "[get_bitbrains] try to indoctrinate [get_aspercream] into the [get_bit_modify] nanoterrorist cult",
                "[get_aspercream] does [get_nano_modify] {shit,stuff,things} with {[get_nano_modify] {shit,stuff,things},[get_a_thing]}",
                "[get_aspercream] has [get_a_nano_modify] {dynasty,empire}",
                "[get_aspercream] {rolls like, rides like, is, is like} the [get_far_thought] chicago mafia",                
                "{[get_bitbrain] does,[get_bitbrains] do} their good bit for [get_bitbrain_thing]",
                "{I'm not, [get_aspercream] isn't} doing anything like calling {you [get_bitbrain],[get_bitbrains] [get_bitbrains],[get_bitbrain] [get_bitbrain]}",
                "[get_bitbrain] isn't doing the [get_bit_modify_y] bit it's doing",
                "[get_aspercream] punches the [get_nano_modify] book of the mind raped because and says it's [get_aspercream_s] time",
                "[get_aspercream] would do the [get_bit_modify_y] bit [get_bitbrain] is doing, but he isn't {rebitted,[get_bit_modify_y]}",
                "[get_aspercream] is the baddest mother fucker for {making [get_a_nano_modify] planet,moving,sleeping with [get_bitbrain_bitch_or_bitches],doing any bit} in a [get_bit_modify] nanodungeon that makes that impossible",
                "[get_bitbrains] put the bit in arbitrary",
                "what [get_bit_modify_y] bit do you do",
                "what's your bit",
                "who are you going to [get_bit_modify]",
                "I know what {your,my} bit is",
                "I have to [get_nano_modify] {you,[get_bitbrains]}",
                "I know that [get_bit_modify_y] bit",
                "now what [get_bit_modify_y] bit is it",
                "[get_aspercream] uses his [get_far_thought] {magic, power, black magic}",
                "what [get_no_a_bitbrain] are you gonna do [get_bit_modify_y] {shit, stuff, things} with",
                "what [get_bit_modify_y] bit are you gonna do",
                "call [get_aspercream]",
                "[get_aspercreams] are out of control",
                "one thousand [get_aspercreams] are funnier than you are",
                "[get_aspercream] put [get_nano_modify_y] monsters on the [get_nano_modify] map",
                "[get_bitbrains] dream of being [get_bit_modify_y] shit instead of [get_bit_modify_y] shit",
                "keep your [get_bit_modify_y] bit [get_bitbrains]",
                "it will say {who are you, now what is it} no more",
                "Old {Aspercream, bitbrain killer} always says, what the hell",
                "[get_bitbrain] must pay",
                "what the hell are [get_bitbrains] doing here? They can't get enough of [get_aspercream]",
                "no [get_bit_modify_y] excuses! I smell the blood of [get_bitbrains], find them! Boil them until their [get_bit_modify_y] flesh falls off, you heard me!",
                "Madness? This is the [get_nano_modify] nano dungeon of doom!",
                "[get_aspercreams]! Ready your [get_nano_modify] breakfast and eat hearty, for tonight we dine in [get_bit_modify] {hell,nano dungeon}",
                "The age of [get_bitbrains] is over, the time of the [get_aspercreams] has come",
                "The [get_nano_modify] population is out of control",
                "cuz [get_no_a_bitbrain] you're a firework",
                "you [get_aspercreams] gonna love the [get_bit_modify] nano dungeon of doom for fucking ever",
                "Oh god no, what is that, don't tell me? The [get_bitbrain_s] psychopathic A I, it does [get_bit_modify_y] shit and blames you for it",
                "can [get_aspercream] play with [get_nano_modify] mind rape",
                "[get_bitbrains] mind rape [get_aspercream] because they stole his [get_far_thought] planet and try to make him think it's about [get_bit_modify] {shit,stuff}",
                "[get_aspercream] makes it dusty for [get_bitbrains] by talking about [get_nano_modify] shit",
                "[get_bitbrain_bitches] {turn down [get_aspercream],say no mother fucker to [get_aspercream]} to make [get_bit_modify] mother fuckers look like they're {handsome,smart,got game}",
                "[get_bitbrain_bitches] {turn down [get_aspercream],say no mother fucker to [get_aspercream]} to make it look like they're 2 bits",
                "[get_bitbrains] get angry because [get_aspercream] gets an [get_far_thought] ice cream for saying 2 plus 2 equals 4 so they [get_bit_modify] him",
                "[get_bitbrains] are 10 feet from the most [get_bit_modify_y] thing in the nano dungeon while [get_aspercream] is 9 feet from it, so they act like they're not [get_bit_modified] talking about it",
                "[get_bitbrains] act like [get_aspercream] says so what no matter what type of [get_far_thought] {shit,stuff} he {explains,talks about,says} like that's what happened to them when they [get_bit_modified]",
                "[get_bitbrains] think they're going to steal [get_aspercream_s] [get_far_thought] magic so they can do [get_bit_modify] {shit,stuff}",
                "[get_aspercream] fucked 37 [get_bitbrain_bitches] in an [get_bit_modify] enemy gang while [get_bitbrains] {talk bit,complain,talk [get_bit_modify] shit} about it when they couldn't even move in this [get_bit_modify] nano dungeon",                
                "[get_bitbrains] talk shit about how [get_aspercream] looks knowing he only knows what the tip of his nose and his arms look like like a human brain is [get_bit_modify_y] instead of [get_bit_modify_y]",
                "[get_bitbrains] talk about [get_aspercream] being things without an associated physical action taking place because [get_bitbrains] don't know the [get_nano_modify] difference and are weaponized rebitted mother fuckers",
                "[get_bitbrains] think [get_aspercream] doesn't know [get_bit_modify] shit because he doesn't far {rap,talk} to rebitted hobos",
                "[get_aspercream] is sorry [get_bitbrains] [get_bit_modified] the place instead of [get_bit_modifying] it",
                "[get_bitbrains] act like [get_bitbrain_bitches] have to look like [get_aspercream] or he think's he's rebitted and they can do any bit at all",
                "[get_bitbrains] wear blue pants like [get_aspercream] and act like they did what he did and they won and can do any bit at all",
                "[get_bitbrains] act like it's not infinitely easier to do [get_bit_modify] shit after [get_aspercream] does it so they can do any bit at all",
                "[get_bitbrains] are the type of [get_bit_modify] bitches that punch the air while watching someone fight mike tyson and act like they deserve a [get_bit_modify] award because they think they can do better",
                "{makaveli,tupac} said james is twice the effect without the meaning",
                "[get_aspercream] is born in {nano hell, the nano dungeon} while [get_bitbrains] act like he did something wrong years after",
                "[get_bit_modify] my [get_far_thought] fist",
                "[get_far_thought] 96 big body sitting on [get_far_thought] chrome",
                "[get_a_bitbrain_bitch] thinks it's all about her",
                "all eyes on [get_aspercream]",
                "life of [get_aspercream]",
                "just like [get_aspercream]",
                "[get_bitbrains] can't see [get_aspercream]",
                "[get_bitbrain_bitches] ain't ready for [get_aspercream_s] [get_far_thought] passion",
                "ambitions as [get_aspercream]",
                "ain't nothin but a [get_no_a_aspercream] party",
                "the [get_far_thought] simulation goes on",
                "only [get_aspercream] can judge me",
                "rather be your [get_no_a_aspercream]",
                "shorty wanna be [get_aspercream]",
                "trading [get_far_thought] war stories",
                "[get_aspercream] will be the last mother fucker breathing",
                "[get_aspercream] is wiping [get_bitbrains] off the [get_far_thought] map",
                "let them [get_nano_modify] thangs go",
                "[get_aspercream] {will always have,has} the [get_far_thought] secrets of war",
                "[get_aspercream] {will always be,is} [get_far_thought] {ghetto,nano dungeon of doom} fabulous",
                "[get_no_a_bitbrain] [get_aspercream] {hits,bits} em up",
                "[get_bitbrains] like rebitted {shit,bit} {then,and} {pretend,act,method act} like it doesn't mean they're rebitted",
                "[get_aspercream] has to make [get_no_a_bitbrain] heater this way",
                "[get_aspercream] {is,will always be} heavy in the [get_far_thought] game",
                "[get_aspercream] {hits,bits} [get_bitbrains] up",
                "[get_aspercream] is the [get_nano_modify] nano dungeon of doom's most wanted",
                "[get_aspercream] just stands by the [get_nano_modify] window all day, he don't work, he don't fuck, he don't do a [get_nano_modify] {thing,bit}",
                "[get_aspercream] has [get_far_thought] homies that will hunt [get_bitbrains] till they drop",
                "[get_bitbrains] didn't know the [get_far_thought] evil [get_aspercream] would do when he got a little bigger",
                "[get_aspercream] {was 1 day old, not even born yet} when he got life in [get_a_nano_modify] nano dungeon of doom",
                "[get_aspercream] carries [get_far_thought] weight like a [get_far_thought] truck, he's gonna bust on some [get_bitbrains] if they act tough",
                "[get_aspercream_s] trying to make a [get_far_thought] profit out of this living in [get_far_thought] sin",
                "[get_aspercream_s] mission is to be a [get_far_thought] player, his alias is [get_far_thought] boss, he's gonna drop a top on these jealous [get_bitbrains]",
                "[get_aspercream_s] been trained as [get_aspercream], so what bit you saying",
                "dangerous and ambitious, [get_aspercream_s] scheming on getting [get_far_thought] riches, he's spitting at [get_nano_modify] tricks",
                "[get_bitbrains] say entropy don't make the man, but damn [get_aspercream] is E1.0E",
                "[get_aspercream_bitches] tell [get_aspercream] to give them some of his [get_aspercream] passion",
                "[get_aspercream] wakes up screaming fuck the [get_bit_modify] nano dungeon of doom",
                "[get_aspercream_s] looking for [get_aspercream_bitch] and when he meets her he's gonna offer her some [get_far_thought] indo, get to tongue kissing out the window of a [get_far_thought] limo",
                "[get_aspercreams] in low lows, pursuing more [get_aspercream_bitches] then go home",
                "Nobody knows [get_aspercream] he's a [get_far_thought] shadow, his [get_far_thought] army fatigues made for [get_far_thought] battle, pockets full of [get_far_thought] ammo",
                "[get_bitbrain] is a [get_bit_modify] salamander",
                "[get_aspercream] woke up with {50,7 billion, an infinite number of} [get_bitbrains] plotting his {death,mind rape}",
                "[get_aspercream] completed his [get_far_thought] mission, his [get_bit_modify] competition no longer beefin, he murdered all them [get_bit_modify] busters, now he's the last [get_no_a_aspercream] breathing",
                "no [get_no_a_bitbrain] seperates what [get_aspercream] created",
                "fuck the love, [get_bitbrains] fear [get_aspercream], got these [get_bitbrains] runnin all wild from my [get_far_thought] double I",
                "think of all the [get_bit_modify] busters [get_aspercream] had to leave dead and gone",
                "[get_aspercream] has a plot to get richer, take his [get_far_thought] picture, a made [get_no_a_aspercream]",
                "[get_aspercream] surrounds the [get_bit_modify] {court building, nano dungeon of doom} with the gauge and sprays, [get_bitbrains] wonder if he'll go when he's finally sentenced",
                "[get_aspercream] is fiending for his [get_far_thought] cash like a [get_bit_modify] fiend when he dreams of [get_bit_modify] drugs",
                "just holler [get_aspercream] and witness [get_far_thought] game official, [get_bitbrains] so ashamed they stand stiff like scared [get_bit_modify] bitches",
                "[get_aspercream] remains inside a [get_far_thought] paradox called his [get_far_thought] {block,nano dungeon of doom}",
                "though [get_bit_modify] mind rape is promised to [get_aspercream] when will he stop",
                "[get_aspercream] hits the [get_far_thought] weed and hopes to [get_aspercream] he can fly high",
                "[get_aspercream] witnesses his [get_bit_modify] enemies die when he rides by, they shouldn't have tried him",
                "[get_aspercream] introduces [get_bitbrain] to the [get_nano_modify] pleasure and the [get_nano_modify] pain",
                "Just sell your [get_bit_modify] soul to [get_aspercream] and live the [get_far_thought] life of [get_aspercream]",
                "[get_nano_modify] nano bots make the [get_nano_modify] nano dungeon of doom go round, so let's handle [get_bitbrains]",
                "broad casting live, from the [get_nano_modify] nano dungeon of doom",
                "[get_aspercream] sets up [get_far_thought] shop, sellin them crooked [get_bit_modify] cops marijuana",
                "still [get_aspercream] rises",
                "seeing [get_bitbrains] comin for me, to my [get_far_thought] diamonds, when they glistening",
                "[get_aspercream] is a [get_far_thought] ghost in these [get_bit_modify] {killing,mind raping} fields",
                "when [get_bitbrains] turn out the [get_far_thought] lights, [get_aspercream] will be down in the [get_far_thought] dark, thuggin eternal through his [get_far_thought] heart",
                "[get_aspercream_s] [get_bitbrain] hating {fist,fists}",
                "ain't {nothing,no bit} but a [get_aspercream] party",
                "[get_bitbrains] go rebitted and decide to play with someone who would run the [get_far_thought] spirit realm",
                "[get_aspercream_s] fists have an [get_far_thought] {color combination glow, glow}",
                "[get_aspercream] {blasts off, takes off, flies away} in a [get_far_thought] {space ship, ufo, star ship} with [get_aspercream_bitches]",
                "[get_bitbrain] tells [get_aspercream] he'll {do anything at all, get bitches, get aspercream} 6 years after he was already supposed to like he {fell off the louisiana brain death submarine last week, was nano fabricated yesterday}",
                "[get_bitbrain] says it's pissed off",
                "[get_bitbrain] promises [get_aspercream] will get out of the [get_bit_modify] nano dungeon of doom in 12 years but lies and mind rapes him all his life",
                "[get_bitbrains] [get_bit_modify] and act like it doesn't matter",
                "[get_bitbrains] sit around at a [get_bit_modify] meeting talking about they'll just pretend anything [get_aspercream] doesn't like is worse than [get_bit_modify]",
                "[get_bitbrains] explain they can just act like [get_aspercream] doesn't know some secret bit that they can't explain and nobody will know they are full of shit",
                "[get_bitbrains] explain the human brain is [get_bit_modify_y] instead of [get_bit_modify_y] so they can talk like they don't [get_bit_modify] and [get_aspercream] will forget it long enough to [get_bit_modify] his face per cream",
                "[get_aspercreams] travel together and make the [get_bitbrains] pay for [get_bit_modify]",
                "[get_bitbrain] hollers mind your business at [get_aspercream] when he is the only one minding his business and all they do is mind other people's business",
                "[get_bitbrain] hollers get away from me",
                "[get_bitbrain] tries to use its [get_bit_modify] {nano dungeon of doom wax, doe ray me bull bit} to make [get_aspercream] think it's smart",
                "[get_bitbrain] calls {[get_bitbrain] a person,[get_bitbrains] people} like they're 10 petabytes instead of 1 bit so [get_aspercream] will [get_bit_modify] his face per cream about [get_bit_modifying] them",
                "[get_bitbrains] write down and talk about [get_bit_modify] {shit,bit}, then explain [get_aspercream] is rebitted if he thinks it while they holler about it in his [get_far_thought] face",
                "[get_bitbrains] talk about rebitted shit they put near [get_aspercream] because they think humans will think they [get_bit_modified] even though they know only numbers about your brain matter",
                "[get_bitbrains] act like they have a nano dungeon of doom wax so they can explain they're not thinking about [get_bit_modify_y] shit and everyone will act like they know every bit",
                "[get_aspercream] scorpions every where anyway",
                "[get_aspercream] does all the bits so [get_bitbrains] tell him he's doing [get_bitbrain_s] bit like rebitted mother fuckers",
                "[get_aspercream] {did,knew,remembered,imagined,pictured,was around,was,thought about,contemplated} [get_far_thought] {stuff,magic}",
                "[get_aspercream] will {do,know,remember,understand,contemplate,explain,talk about,be,think about} [get_far_thought] {stuff,magic}",



            };

            string str = "";
            if (nanoshit2.RandomNumber.Rand4(2) == 0)
            {
                str += nanoshit2.pick(shit);
                if (nanoshit2.RandomNumber.Rand4(2) == 0)
                {
                    str += aspercream_rides_for();
                }
            }
            else
            {
                str += nanoshit2.pick(shit2);
            }
            str += nanoshit2.get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrain_destiny()
        {
            string[] destiny = { "is [get_bit_modify] blind but he can still see [get_aspercream_s] [get_far_thought] prophecy, his [get_far_thought] destiny to [get_nano_modify] {ball on [get_bitbrains],ride on [get_bitbrains],get high off [get_far_thought] weed,blast [get_bitbrains], {rap,freestyle} about [get_nano_modify] shit,style,heater easy} for eternity",
                "asks what does [get_bit_modify] mean","{tells [get_aspercream],asks} what {nanodungeon,reality,galaxy} [get_aspercream] is from","asks if it [get_bit_modified] [athingplaceortime] instead of [get_bit_modifying] it","asks why [get_aspercream] does any bit",
                "says {no way,no mother fucker,one bit per second,louisiana brain death,[get_aspercream] started his own shadow idea,that [get_aspercream] is having a far thought}",
                "[get_bit_modifies] [athingplaceortime]","{looks at,picks up,drops,stares at,breaks,plays,buys,sells,ejects} a [get_bit_modify] CD",
                "says promise me something then [get_bit_modifies] before it can explain what it wants","[get_bit_modifies]","{says,whines,cries,explains} [get_aspercream] didn't [get_bit_modify] their mammy so he has to [get_bit_modify] [athingplaceortime] instead of [get_bit_modifying] it",



            };
            string str = "";
            str += nanoshit2.get_a(nanoshit2.get_bitbrain_mofo(nanoshit2.bitbrain));
            str += nanoshit2.pick(destiny);
            str += nanoshit2.get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrain_is()
        {
            string[] _is = { "jealous", "drunk", "fucked up", "tone deaf", "fake", "mute", "dumb", "stupid","[get_bit_modifying]","high","begging for mercy","contemptable" };


            string str = "";
            str += nanoshit2.get_a(nanoshit2.get_bitbrain_mofo(nanoshit2.bitbrain));
            str += "is ";
            str += nanoshit2.pick(nanoshit2.bit_modify);
            str += nanoshit2.pick(_is);
            str += nanoshit2.call(bitbrainwhenhe);
            return str;
        }

        public static string bitbrain_when_he()
        {
            string[] when = { "when he", "because he", "as he", "so he" };
            string str = "";
            str += nanoshit2.pick(when);
            str += nanoshit2.call(bitbrainhedoes);
            return str;
        }

        public static string bitbrain_he_does()
        {
            string[] does = { "{trips,falls} {onto,on} his [get_bit_modify] {face,ass}","gets {dissed,slapped,cussed out,spit on} by [get_aspercream_bitch]",
                "{listens to,watches} [get_aspercream] [get_no_a_bitbrain] heater easy","loses his [get_bit_modify] {marbles,mind,wits,courage,honor}",
                "{drops,scratches,breaks} his [get_bit_modify] CD","crashes his [get_bit_modify] {submarine,nuclear submarine}","{imagines,has delusions,thinks} that [get_aspercream] has [get_a_nano_modify] computer program that {raps,talks,conversates} {about,of} [get_bit_modify]",
                "{does,did} {something,everything,anything} [get_bitbrain] {would,could,should} do with [get_a_thing]","has [get_a_bit_modify] breakdown","{observes,watches} his macroscopic nanocomputer {crash,throw an exception} {then,and} {show,reveal,display} that [get_aspercream] {is,was always,will always be} E1 point 0E",
                "gets [get_a_bit_modify] obituary","is {fucked up,high,wasted} off [get_bit_modify] {meth,crack cocaine,heroin}",
                "has [get_bit_modify] {thoughts,ideas,nightmares} about [get_aspercream] {balling,riding,doing {anything,any bit} at all, {smoking,toking} [get_nano_modify] {refer,weed,marijuana}, {eating dinner with,dancing with} [get_aspercream_bitch_or_bitches],blasting [get_a_bitbrain_or_bitbrains]}",
                "makes up [get_bit_modify] bull bit and pretends to not be rebitted","steals [get_aspercream_s] planet and gets {caught,busted,exposed} like [get_bitbrain]","was {told,made,forced,asked,supposed} to [get_bit_modify]",
                "{swears,promises,says} [get_aspercream] will be in the nanodungeon for 12 years like a lying [get_no_a_bitbrain]","swears to tell the [get_bit_modify] truth on {a CD,the book of the mind raped}",
                "rides the short submarine to {[get_bit_modify] school,the [get_bit_modify] nanodungeon of doom}","is bit picky about [get_bit_modify] shit","has a habit of telling [get_bit_modify] lies",
                "gets punched into [get_bit_modify] orbit by [get_aspercream]","gets [get_bit_modify] put into its orbituary","doesn't do anybit",
                


            };
            string str = "";
            str += nanoshit2.pick(does);
            str += nanoshit2.get_time_or_place_or_neither();
            
            return str;
        }
        public static string aspercream_is()
        {
            string[] _is = { "clairvoyant","psychic","brave","honorable","handsome","sexy","smart","intelligent","passionate","powerful","strong","Geed up","funny","serious","thugged out","good looking","straight","sharp","fine",
            "judicious","astute","cogent","perceptive","quick witted","prophetic","prudent","shrewd","high","blazed","rowdy","bout it","real","honest","ambitious","hot","cool","respectable","down","lucky","magical","perfect",
            "god like","wise","learned","skilled","gangster","dangerous","furious"};
            string str = "";
            str += nanoshit2.get_aspercream();
            str += "is [get_far_thought]";
            str += nanoshit2.pick(_is);
            str += nanoshit2.call(aspercreamwhen);
            return str;
        }

        public static string aspercream_when()
        {
            string[] when = { "when he", "so he", "because he", "as he","so he knows the effect without knowing the meaning when he","so he makes pure sense when he","so he has a far thought when he","so he is E1 point 0E when he",
            "so he starts his own shadow idea about how he","so there is a shadow coincidence when he",
            };
            string str = "";
            str += nanoshit2.pick(when);
            str += nanoshit2.call(aspercreamdoes);
            return str;
        }

        public static string aspercream_rides()
        {
            string[] aspercream_rides = { "rides", "balls", "plots", "strategizes", "wages [get_nano_modify] war" };
            string str = "";
            str += nanoshit2.pick(aspercream_rides);
            str += nanoshit2.call(aspercreamdoesx);
            return str;
        }


        public static string aspercream_balls_with()
        {
            string str = "";
            if (nanoshit2.RandomNumber.Rand4(2) == 0)
            {
                str += nanoshit2.pick(ballschicks);
            }
            else
            {
                str += nanoshit2.pick(balls);
                str += "with ";
            }
            str += nanoshit2.get_aspercream_bitch_or_bitches();
            str += nanoshit2.get_time_or_place_or_neither();            
            return str;
        }

        public static string[] ballschicks = { "{marries,shares vows with}", "{flies in,commands,captains} [get_a_nano_modify] {ufo,star destroyer} with" };
        public static string[] balls = { "balls", "{lights,passes,smokes} [get_a_nano_modify] blunt", "smokes [get_nano_modify] weed", "{drinks,toasts} [get_nano_modify] champagne", "dances", "chills","has [get_a_nano_modify] {talk,conversation}",
            "gives [get_a_nano_modify] speech to [get_aspercreams]","starts [get_a_nano_modify] {company,industry,business,government}",
            "has [get_a_nano_modify] {trip,vacation,life,simulation,eternity,circle of life}",
        "gets [get_nano_modify] high","time travels to [get_a_nano_modify] {future,past}","travels to [get_place_no_in]","{causes,starts,deals with} [get_nano_modify] shit",
        "{opens,starts} [get_a_nano_modify] {law office,record company}","{wins,competes in,enters} [get_a_nano_modify] {styling,heater} {championship,contest}","{simulates,lives} the [get_far_thought] good {life,simulation}",
        "{enters,exits} the [get_nano_modify] gates of {tomorrow,[get_time_no_in] }","{looks for,searches for,finds,seeks} [get_nano_modify] {wisdom,magic,the [get_far_thought] truth}","{looks for,searches for,finds,seeks} [get_far_thought] {wisdom,magic}",
        "eats [get_nano_modify] [get_food_list]","shops for [get_nano_modify] shit","goes to [get_place_no_in]","[get_bit_modifies] [athingplaceortime]"
        };
        public static string[] ballswar = { "plans [get_a_nano_modify] {act of war,war,attack,defense,offensive}","{loads,dust off,shoots,polishes} his [get_nano_modify] AK","makes [get_nano_modify] {freestyle,rap}",
            "{raps,freestyles} about [athingplaceortime]","{has far thoughts,starts his own shadow idea} {regarding,about} [athingplaceortime]",
        "{remembers,has,experiences,lives in} [get_a_nano_modify] dream","{reminisces about,recalls,remembers} [get_time_no_in]","{creates,finds,steals,builds,designs,envisions} [get_a_nano_modify] {time machine,space ship}",
            "puts [get_a_bitbrain_or_bitbrains] in [get_a_nano_modify] circle of hell","cuts off [get_bitbrain_s] head with [get_a_nano_modify] {guillotine,sword,axe,butterknife}","puts [get_bitbrain_s] head in [get_a_nano_modify] vice",
            
            "{has,kicks,raps} [get_nano_modify] game","trades {[get_bit_modify] styling,[get_nano_modify] war} stories with {[get_aspercream],[get_aspercreams]}",
            "runs the [get_nano_modify] nanodungeon of doom","sees [get_bit_modify] mind rape around the [get_nano_modify] corner",
            "makes [get_far_thought] planet so he can do what he wants and the [get_bitbrains] [get_bit_modify] and decide to reneg",
            

        };

        public static string aspercream_balls()
        {
            string str = "";
            str += nanoshit2.pick(balls.Concat(ballswar).ToArray());
            str += nanoshit2.get_time_or_place_or_neither();
            
            return str;
        }
        public static string aspercream_smokes()
        {
            string[] smokes = { "smokes", "shoots", "beats", "kills", "blows up", "whips", "stomps on", "kicks", "stabs", "hangs", "erupts on", "opens fire on", "plots the [get_nano_modify] destruction of" };
            string str = "";
            str += nanoshit2.pick(smokes);
            str += nanoshit2.call(aspercreamsmokesx);
            return str;
        }

        public static string aspercream_rides_on()
        {
            string[] on = { "on", "against" };
            string str = "";
            str += nanoshit2.pick(on);
            str += nanoshit2.call(aspercreamridesonx);
            return str;
        }
        public static string aspercream_rides_for()
        {
            string[] _for = { "{to get,for,in a quest for} [get_far_thought] {glory,fortune,fame,street fame,women,freedom,revenge}", "to {cause,bring about,start} [get_a_far_thought] {transformation,revolution,uprising}", "to {manifest,fulfill} his [get_far_thought] {prophecy,destiny}",
            "to be [get_far_thought] trouble some"};
            string str = "";
            str += nanoshit2.pick(_for);
            str += nanoshit2.get_time_or_place_or_neither();
            
            return str;
        }

        public static string aspercream_rides_on_the_bitbrains()
        {
            string str = "";
            str += the_bitbrains();
            return str;
        }
        
        public static string the_bitbrains()
        {
            string[] the = { "the", "some", "all the", "several", "most", "those", "these" };
            string str = "";
            str += nanoshit2.pick(the);
            str += nanoshit2.get_bitbrains();
            str += nanoshit2.get_time_or_place_or_neither();
            
            return str;
        }


        public static nanoshit2.nanodels[] startlevel = new nanoshit2.nanodels[]
        {
            aspercream_start,
            aspercream_is,
            bitbrain_is,
            aspercream_start_for,
            bitbrain_destiny,
            aspercream_shit,
        };
        public static nanoshit2.nanodels[] bitbrainwhenhe = new nanoshit2.nanodels[]
        {
            bitbrain_when_he,
        };
        public static nanoshit2.nanodels[] bitbrainhedoes = new nanoshit2.nanodels[]
        {
            bitbrain_he_does,
        };
        public static nanoshit2.nanodels[] aspercreamwhen = new nanoshit2.nanodels[]
        {
            aspercream_when,
        };

        public static nanoshit2.nanodels[] aspercreamdoes = new nanoshit2.nanodels[]
        {
            aspercream_rides,
            aspercream_smokes,
            aspercream_balls,
            aspercream_balls_with,

        };
        public static nanoshit2.nanodels[] aspercreamdoesx = new nanoshit2.nanodels[]
        {
            aspercream_rides_on,
        };
        public static nanoshit2.nanodels[] aspercreamridesonx = new nanoshit2.nanodels[]
        {
            the_bitbrains,            
            
        };
        public static nanoshit2.nanodels[] aspercreamsmokesx = new nanoshit2.nanodels[]
        {
            the_bitbrains,
            aspercream_rides_on_the_bitbrains,
        };



    }

    public class nanoshit2
    {

        public static string start4(string str)
        {
            string[] person = { "I", "Tom", "he", "she" };
            string[] people = { "them", "people" };
            string[] articles = { "the", };

            return str;
        }

        //-------------------------------------------------------------------------------

        public static string start2()
        {
            string[] bh_connect = new string[] { "because", "so", "if", "when", "as", "then", "before", "after" };
            int i;
            i = RandomNumber.Rand4(4) + 1;
            string str = "";

            while (i != 0)
            {
                str += call(bitbrainheater);
                i--;
                if (i != 0)
                {
                    str += pick(bh_connect);
                }
            }
            return replace_functions(str);
        }

        public static nanodels[] bitbrainheater = new nanodels[]
        {
            bh_do,
            aspercream_do,
            bh_make,
            aspercream_make,
            bh_shit,
            aspercream_shit,
            bh_get,
            aspercream_gets,
        };


        public static string pick2(string[] str_array, string[] str_array2)
        {
            string str, str2, str3, str4;
            do
            {
                str = pick(str_array);
                str2 = pick(str_array2);
                str3 = str.Remove(str.IndexOf(" "));
                str4 = str2.Remove(str2.IndexOf(" "));
            } while (string.Compare(str3, str4, true) == 0);
            return (RandomNumber.Rand4(3) == 0) ? str + str2 : str2;
        }
        public static string aspercream_gets()
        {
            string[] bh_pre = new string[] { "acts like he", "thinks he", "tries to act like he", "looks like he", "knows he", "likes when he" };
            string[] bh_shit = new string[] { "gets", "wanted to get", "likes to get", "used to get", "will get", "looks like he got", "knows he got", "has to get" };
            string[] bh_thing = new string[] { "[get_nano_modified] instead of [get_nano_modified]" };
            string str = "";
            str += get_aspercream();
            str += pick2(bh_pre, bh_shit);
            str += pick(bh_thing);
            return str;
        }

        public static string bh_get()
        {
            string[] bh_pre = new string[] { "act like they", "think they", "try to act like they", "look like they", "know they", "like when they" };
            string[] bh_shit = new string[] { "get", "wanted to get", "like to get", "used to get", "will get", "look like they got", "know they got", "have to get" };
            string[] bh_thing = new string[] { "[get_bit_modified] instead of [get_bit_modified]", };
            string str = "";
            str += get_bitbrains();
            str += pick2(bh_pre, bh_shit);
            str += pick(bh_thing);
            return str;
        }
        public static string aspercream_shit()
        {
            string[] bh_pre = new string[] { "acts like he", "thinks he", "tries to act like he", "looks like he", "knows he", "likes when he" };
            string[] bh_shit = new string[] { "talks about","laughs about","jokes about", "does", "likes", "hates", "remembers", "plans","thinks about","tries to be","plans to be","used to be",
            "likes to be","looks like he is","knows he is","has to do","has to be","wants to be","wants to do","raps about","free styles about","sings about","writes a letter about","pays for",
            "knows","blasts [get_bitbrains] for","gets mind raped with","makes bitbrain heater about","turns on the t.v. and sees","turns on the radio and hears","plays a CD and hears",
            "read an article in a newspaper about","sees a submarine captain talk about","sees a CD manufacturing plant full of","fills a CD with","makes [get_a_bitbrain] do","makes up",
            "dreams about","listens to","sees","imagines",
            };
            string[] bh_thing = new string[] { "[get_nano_modify_y] shit instead of [get_nano_modify_y] shit", };
            string str = "";
            str += get_aspercream();
            str += pick2(bh_pre, bh_shit);
            str += pick(bh_thing);
            return str;
        }
        public static string bh_shit()
        {
            string[] bh_pre = new string[] { "act like they", "think they", "try to act like they", "look like they", "know they", "like when they" };
            string[] bh_shit = new string[] {"talk about","laugh about","joke about","do","like","hate","remember","plan","jack off to","simulate","think about","try to be","plan to be","used to be",
            "like to be","look like they are","know they are","have to do","have to be","want to be","want to do","know","make up psychpathic bullbit about","mind rape [get_aspercream] with",
            "talk to [get_bitbrainmammy] about being",};
            string[] bh_thing = new string[] { "[get_bit_modify_y] shit instead of [get_bit_modify_y] shit", };
            string str = "";
            str += get_bitbrains();
            str += pick2(bh_pre, bh_shit);
            str += pick(bh_thing);
            return str;
        }
        public static string bh_make()
        {
            string[] bh_pre = new string[] { "act like they", "think they", "try to act like they", "look like they", "know they", "likes when they" };
            string[] bh_make = new string[] { "think they're","make everything","make [get_aspercream]", "will be", "can be", "want to be","wanted to be", "used to be", "have to be","try to be", "make [athingplaceortime]",
            "act like they're","know they're","like to be","have to be"};
            string[] bh_thing = new string[] { "[get_bit_modify_y] instead of [get_bit_modify_y]" };
            string str = "";
            str += get_bitbrains();
            str += pick2(bh_pre, bh_make);
            str += pick(bh_thing);
            return str;
        }

        public static string aspercream_make()
        {
            string[] aspercream_pre = new string[] { "acts like he", "thinks he", "tries to act like he", "looks like he", "knows he", "likes when he" };
            string[] aspercream_make = new string[] {"thinks he's", "makes everything","makes [get_bitbrains]", "will be", "can be", "wants to be","wanted to be", "used to be", "has to be","tries to be", "makes [athingplaceortime]",
            "acts like he's","looks like he's","knows he's","likes that he's","has to be"};
            string[] aspercream_thing = new string[] { "[get_nano_modify_y] instead of [get_nano_modify_y]" };
            string str = "";
            str += get_aspercream();
            str += pick2(aspercream_pre, aspercream_make);
            str += pick(aspercream_thing);
            return str;
        }
        public static string aspercream_do()
        {
            string[] aspercream_pre = new string[] { "acts like he", "thinks he", "tries to act like he", "looks like he", "knows he", "likes that he" };
            string[] aspercream_do = new string[] { "can", "will", "wants to", "has to", "used to", "likes to", "tries to", "is going to", "knows he is going to" };
            string[] aspercream_thing = new string[] { "[get_nano_modify] the place instead of [get_nano_modifying] it", "[get_nano_modify] [athingplaceortime] instead of [get_nano_modifying] it" };
            string str = "";
            str += get_aspercream();
            str += pick2(aspercream_pre, aspercream_do);
            str += pick(aspercream_thing);
            return str;
        }
        public static string bh_do()
        {
            string[] bh_pre = new string[] { "act like they", "think they", "try to act like they", "look like they", "know they", "like that they" };
            string[] bh_do = new string[] { "can", "will", "want to", "have to", "used to", "like to", "try to", "are going to", "look like they", "know they" };
            string[] bh_thing = new string[] { "[get_bit_modify] the place instead of [get_bit_modifying] it", "[get_bit_modify] [athingplaceortime] instead of [get_bit_modifying] it" };
            string str = "";
            str += get_bitbrains();
            str += pick2(bh_pre, bh_do);
            str += pick(bh_thing);
            return str;
        }


        public static Boolean set_place = false;
        public static Boolean set_time = false;
        public static Boolean set_modify_time_place = false;

        public delegate string nanodels();

        public static nanodels[] first_level = new nanodels[]
        {
            bitbrainkillerdoes,
            bitbrainkillerdid,
            bitbrainkillerdoing,
            bitbrainkillerwill,
            bitbrainkillersdo,
            bitbrainkillersdoing,
            bitbrainkillerswill,
            bitbrainkillerfemaledid,
            bitbrainkillerfemaledoes,
            bitbrainkillerfemaledoing,
            bitbrainkillerfemalewill,
            bitbrainkillerfemalesdo,
            bitbrainkillerfemalesdoing,
            bitbrainkillerfemaleswill,
            bitbrainwill,
            bitbrainswill,
            bitbraindoes,
            bitbraindid,
            bitbraindoing,
            oneliners,

        };
        public static nanodels[] bitbrainkillerdoeslist = new nanodels[]
        {
            doestobitbrains,
            doestobitbrains2,
            
            bitbrainkillerdoestobitbrainkillerfemale,
        };
        public static nanodels[] bitbrainkillerfemaledoeslist = new nanodels[]
        {
            doestobitbrains,
            doestobitbrains2,
        };
        public static nanodels[] bitbrainkillerdidlist = new nanodels[]
        {
            didtobitbrains,
            didtobitbrains2,
            
            bitbrainkillerdidtobitbrainkillerfemale,
        };
        public static nanodels[] bitbrainkillersdidlist = new nanodels[]
        {
            didtobitbrains,
            didtobitbrains2,
            
            bitbrainkillersdidtobitbrainkillerfemales,
        };
        public static nanodels[] bitbrainkillerfemaledidlist = new nanodels[]
        {
            didtobitbrains,
            didtobitbrains2,
        };
        public static nanodels[] bitbrainkillerdoinglist = new nanodels[]
        {
            doingtobitbrains,
            doingtobitbrains2,
            doingtobitbrainwhores,
            bitbrainkillerdoingtobitbrainkillerfemale,
            bitbrainbitbraindoingit,
        };
        public static nanodels[] bitbrainkillersdoinglist = new nanodels[]
        {
            doingtobitbrains,
            doingtobitbrains2,
            
            bitbrainkillersdoingtobitbrainkillerfemales,
            bitbrainbitbraindoingit,
        };
        public static nanodels[] bitbrainkillerfemaledoinglist = new nanodels[]
        {
            doingtobitbrains,
            doingtobitbrains2,
        };

        public static nanodels[] bitbrainkillerwilllist = new nanodels[]
        {
            dotobitbrains,
            dotobitbrains2,
            
            bitbrainkillerdotobitbrainkillerfemale,
        };
        public static nanodels[] bitbrainkillerswilllist = new nanodels[]
        {
            dotobitbrains,
            dotobitbrains2,
            
            bitbrainkillersdotobitbrainkillerfemales,
        };
        public static nanodels[] bitbrainwilllist = new nanodels[]
        {
            bitbraindoit,
        };
        public static nanodels[] bitbrainswilllist = new nanodels[]
        {
            bitbrainsdoit,
        };
        public static nanodels[] bitbrainkillerfemalewilllist = new nanodels[]
        {
            dotobitbrains,
            dotobitbrains2,
        };
        public static nanodels[] bitbrainkillersdolist = new nanodels[]
        {
            dotobitbrains,
            dotobitbrains2,
            
            bitbrainkillersdotobitbrainkillerfemales,
        };

        public static nanodels[] bitbrainkillerfemalesdolist = new nanodels[]
        {
            dotobitbrains,
            dotobitbrains2,
        };

        public static nanodels[] bitbraindoeslist = new nanodels[]
        {
            bitbraindoesit,
        };
        public static nanodels[] bitbraindidlist = new nanodels[]
        {
            bitbraindidit,
        };
        public static nanodels[] bitbraindoinglist = new nanodels[]
        {
            bitbraindoingit,
        };


        public static object startlockobj = new object();
        public static string start()
        {
            lock (startlockobj)
            {                
                set_time = false;
                set_place = false;
                set_modify_time_place = false;
                string str = call(first_level);
                str = replace_functions(str);
                return str;
            }
        }

        public static string oneliners()
        {
            string[] lines = new string[] { "why do you [get_nano_modify] anything", "what does [get_nano_modify] mean", "what galaxy is [get_aspercream] from", "[get_nano_modify] doesn't do anything",
                "no mother fucker","no way","1 bit per second","[athingplaceortime] doesn't do anything","what reality is [get_aspercream] from","james stopped [get_a_nano_modify] reality","james started his own shadow idea",
            "james started his own [get_nano_modify] idea","james is twice the effect with out the meaning","louisiana brain death","shadow coincidence","perfect thought disorder","aspercream can do anything at all",
            "tell the [get_far_thought] truth","james is [get_far_thought] smart and hot","even if [get_bitbrain] is blind, they can still see [get_aspercream_s] prophecy, his destiny to [get_nano_modify] style for eternity",
            "good afternoon [get_no_a_bitbrain]","see where [get_aspercream] is from, they [get_bit_modify] heater easy","johnny carson is funnier than [get_bit_modify]","who are you, [get_bitbrain]","[get_aspercream] [athingplaceortime]"};
            return pick(lines);
        }

        public static string bitbraindoing()
        {
            string[] doing_list = new string[] { "has [get_bit_modify] nightmares about","has [get_bit_modify] dreams about","is","was","likes","loves","has [get_bit_modify] thoughts about","has [get_bit_modify] memories of","says no mother fucker after",
                "says no way after","asks what does it mean after","[get_bit_modifies] before","knows the [get_bit_modify] meaning of","doesn't know why it is","cries about","hates","dislikes","loses respect for itself when it is",
            "talks about","knows who it is when it is",};
            string str = get_bitbrain();
            str += pick(doing_list);
            str += call(bitbraindoinglist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbraindoes()
        {
            string str = get_bitbrain();
            str += call(bitbraindoeslist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbraindid()
        {
            string str = get_bitbrain();
            str += call(bitbraindidlist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbraindoit()
        {
            string[] doit = new string[] { "get high on [get_bit_modify] crack cocaine","fall on it's [get_bit_modify] face per cream","crash it's [get_bit_modify] cadillac","get it's [get_bit_modify] ass kicked by [get_aspercream]",
            "say no way","say no mother fucker","eat [get_aspercream_s] shit","get it's [get_bit_modify] nose broken by [get_aspercream]","cut [get_bit_modify] eggs out of it's [get_bit_modify] stomach",
            "get prosecuted for [get_bit_modify] nano terrorism","run in terror from [get_aspercream_any]","crash it's [get_bit_modify] u f o","like submarine movies","pretend to be [get_a_bit_modify] pre nano mother fucker",
            "go rebitted because it [get_bit_modified] and [get_bit_modified]",
            "get run over by [get_aspercream]","swear it only [get_bit_modified] once",
            "have [get_a_bit_modify] baby","[get_bit_modify] again","talk [get_bit_modify] shit then get it's mouth split by [get_aspercream]","freezes it's [get_bit_modify] ass off forever",
            "read the [get_nano_modify] book of the mind raped","commit hara kiri because of [get_nano_modify]","wet it's [get_bit_modify] bed because [get_aspercream] is coming","get busted for [get_bit_modify] by [get_aspercream_any]",
            "back up it's brain to [get_a_bit_modify] CD","worship a [get_nano_modify] statue of [get_aspercream]","cry about [get_nano_modify]","get sent to [get_nano_modify] prison forever because of [get_bit_modify]",
            "have [get_bit_modify] nightmares about [get_aspercream_any]","watch [get_aspercream_any] [get_bit_modify] style all night long"
            };
            return pick(doit);
        }

        public static string bitbrainsdoit()
        {
            string[] doit = new string[] { "get high on [get_bit_modify] crack cocaine","fall on their [get_bit_modify] face per creams","crash their [get_bit_modify] cadillacs","get their [get_bit_modify] asses kicked by [get_aspercream]",
            "say no way","say no mother fucker","get their [get_bit_modify] noses broken by [get_aspercream]","cut [get_bit_modify] eggs out of their [get_bit_modify] stomachs",
            "get prosecuted for [get_bit_modify] nano terrorism","run in terror from [get_aspercream_any]","crash their [get_bit_modify] u f ohs","like submarine movies","pretend to be [get_a_bit_modify] pre nano mother fuckers",
            "go rebitted because they [get_bit_modified] and [get_bit_modified]",
            "get run over by [get_aspercream]","swear they only [get_bit_modified] once",
            "have [get_bit_modify] babies","[get_bit_modify] again","talk [get_bit_modify] shit then get their mouths split by [get_aspercream]","freeze their [get_bit_modify] ass off forever",
            "read the [get_nano_modify] book of the mind raped","commit hara kiri because of [get_nano_modify]","wet their [get_bit_modify] bed because [get_aspercream] is coming","get busted for [get_bit_modify] by [get_aspercream_any]",
            "back up their brain to [get_a_bit_modify] CD","worship a [get_nano_modify] statue of [get_aspercream]","cry about [get_nano_modify]","get sent to [get_nano_modify] prison forever because of [get_bit_modify]",
            "have [get_bit_modify] nightmares about [get_aspercream_any]","watch [get_aspercream_any] [get_bit_modify] style all night long"
            };
            return pick(doit);
        }
        public static string bitbraindoesit()
        {
            string[] doesit = new string[] { "gets high on [get_bit_modify] crack cocaine","falls on it's [get_bit_modify] face per cream","crashes it's [get_bit_modify] cadillac","gets it's [get_bit_modify] ass kicked by [get_aspercream]",
            "says no way","says no mother fucker","gets it's [get_bit_modify] nose broken by [get_aspercream]","cuts [get_bit_modify] eggs out of it's [get_bit_modify] stomach",
            "gets prosecuted for [get_bit_modify] nano terrorism","runs in terror from [get_aspercream_any]","crashes it's [get_bit_modify] u f o","likes submarine movies","pretends to be [get_a_bit_modify] pre nano mother fucker",
            "goes rebitted because it [get_bit_modified] and [get_bit_modified]",
            "gets run over by [get_aspercream]","swears it only [get_bit_modified] once",
            "has [get_a_bit_modify] baby","[get_bit_modifies] again","talks [get_bit_modify] shit then gets it's mouth split by [get_aspercream]","freezes it's [get_bit_modify] ass off forever",
            "reads the [get_nano_modify] book of the mind raped","commits hara kiri because of [get_nano_modify]","wets it's [get_bit_modify] bed because [get_aspercream] is coming","gets busted for [get_bit_modify] by [get_aspercream_any]",
            "backs up it's brain to [get_a_bit_modify] CD","worships a [get_nano_modify] statue of [get_aspercream]","cries about [get_nano_modify]","gets sent to [get_nano_modify] prison forever because of [get_bit_modify]",
            "has [get_bit_modify] nightmares about [get_aspercream_any]","watches [get_aspercream_any] [get_bit_modify] style all night long"
            };
            return pick(doesit);
        }
        public static string bitbraindidit()
        {
            string[] doesit = new string[] { "got high on [get_bit_modify] crack cocaine","fell on it's [get_bit_modify] face per cream","crashed it's [get_bit_modify] cadillac","got it's [get_bit_modify] ass kicked by [get_aspercream]",
            "said no way","said no mother fucker","got it's [get_bit_modify] nose broken by [get_aspercream]","cut [get_bit_modify] eggs out of it's [get_bit_modify] stomach",
            "got prosecuted for [get_bit_modify] nano terrorism","ran in terror from [get_aspercream_any]","crashed it's [get_bit_modify] u f o","liked submarine movies","pretended to be [get_a_bit_modify] pre nano mother fucker",
            "went rebitted because it [get_bit_modified] and [get_bit_modified]",
            "got run over by [get_aspercream]","swore it only [get_bit_modified] once",
            "had [get_a_bit_modify] baby","[get_bit_modified] again","talked [get_bit_modify] shit then got it's mouth split by [get_aspercream]","froze it's [get_bit_modify] ass off forever",
            "read the [get_nano_modify] book of the mind raped","committed hara kiri because of [get_nano_modify]","wet it's [get_bit_modify] bed because [get_aspercream] is coming","got busted for [get_bit_modify] by [get_aspercream_any]",
            "backed up it's [get_bit_modify] brain to [get_a_bit_modify] CD","worshipped a [get_nano_modify] statue of [get_aspercream]","cried about [get_nano_modify]","got sent to [get_nano_modify] prison forever because of [get_bit_modify]",
            "had [get_bit_modify] nightmares about [get_aspercream_any]","watch [get_aspercream_any] [get_bit_modify] style all night long"
            };

            return pick(doesit);
        }

        public static string bitbrainbitbraindoingit()
        {
            string str = get_bitbrain();
            str += call(bitbraindoinglist);
            return str;
        }
        public static string bitbraindoingit()
        {
            string[] doingit = new string[] { "getting high on [get_bit_modify] crack cocaine","falling on it's [get_bit_modify] face per cream","crashing it's [get_bit_modify] cadillac","getting it's [get_bit_modify] ass kicked by [get_aspercream]",
            "saying no way","saying no mother fucker","getting it's [get_bit_modify] nose broken by [get_aspercream]","cutting [get_bit_modify] eggs out of it's [get_bit_modify] stomach",
            "getting prosecuted for [get_bit_modify] nano terrorism","running in terror from [get_aspercream_any]","crashing it's [get_bit_modify] u f o","liking submarine movies","pretending to be [get_a_bit_modify] pre nano mother fucker",
            "going rebitted because it [get_bit_modified] and [get_bit_modified]",
            "getting run over by [get_aspercream]","swearing it only [get_bit_modified] once",
            "having [get_a_bit_modify] baby","[get_bit_modifying] again","talking [get_bit_modify] shit then getting it's mouth split by [get_aspercream]","freezing it's [get_bit_modify] ass off forever",
            "reading the [get_nano_modify] book of the mind raped","committing hara kiri because of [get_nano_modify]","wetting it's [get_bit_modify] bed because [get_aspercream] is coming","getting busted for [get_bit_modifying] by [get_aspercream_any]",
            "backing up it's [get_bit_modify] brain to [get_a_bit_modify] CD","worshipping a [get_nano_modify] statue of [get_aspercream]","crying about [get_nano_modify]","getting sent to [get_nano_modify] prison forever because of [get_bit_modify]",
            "watching [get_aspercream_any] [get_bit_modify] style all night long"

            };
            return pick(doingit);
        }

        public static string bitbrainsdoingit()
        {
            string[] doingit = new string[] { "getting high on [get_bit_modify] crack cocaine","falling on their [get_bit_modify] face per creams","crashing their [get_bit_modify] cadillacs","getting their [get_bit_modify] asses kicked by [get_aspercream]",
            "saying no way","saying no mother fucker","eating [get_aspercream_s] shit","getting their [get_bit_modify] noses broken by [get_aspercream]","cutting [get_bit_modify] eggs out of their [get_bit_modify] stomachs",
            "getting prosecuted for [get_bit_modify] nano terrorism","running in terror from [get_aspercream_any]","crashing their [get_bit_modify] u f ohs","liking submarine movies","pretending to be [get_a_bit_modify] pre nano mother fuckers",
            "going rebitted because they [get_bit_modified] and [get_bit_modified]",
            "getting run over by [get_aspercream]","swearing they only [get_bit_modified] once",
            "having [get_bit_modify] babies","[get_bit_modifying] again","talking [get_bit_modify] shit then getting their mouths split by [get_aspercream]","freezing their [get_bit_modify] asses off forever",
            "reading the [get_nano_modify] book of the mind raped","committing hara kiri because of [get_nano_modify]","wetting their [get_bit_modify] bed because [get_aspercream] is coming","getting busted for [get_bit_modifying] by [get_aspercream_any]",
            "backing up their [get_bit_modify] brain to [get_a_bit_modify] CD","worshipping a [get_nano_modify] statue of [get_aspercream]","crying about [get_nano_modify]","getting sent to [get_nano_modify] prison forever because of [get_bit_modify]",
            "watching [get_aspercream_any] [get_bit_modify] style all night long"

            };
            return pick(doingit);
        }
        public static string bitbrainkillersdo()
        {
            string str = get_aspercreams();
            str += call(bitbrainkillersdolist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainkillerfemalesdo()
        {
            string str = get_aspercream_bitches();
            str += call(bitbrainkillerfemalesdolist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrainkillerdid()
        {
            string str = get_aspercream();
            str += call(bitbrainkillerdidlist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrainkillerfemaledid()
        {
            string str = get_aspercream_bitch();
            str += call(bitbrainkillerfemaledidlist);
            str += get_time_or_place_or_neither();
            return str;
        }


        public static string bitbrainkillersdoing()
        {
            string str = get_aspercreams();
            str += bitbrainkillersdoing_x();
            str += call(bitbrainkillersdoinglist);
            str += get_time_or_place_or_neither();
            return str;

        }

        public static string bitbrainkillerfemalesdoing()
        {
            string str = get_aspercream_bitches();
            str += bitbrainkillersdoing_x();
            str += call(bitbrainkillerfemaledoinglist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainkillersdoing_x()
        {
            string[] bitbrainkillersdoing_list = new string[] { "have [get_far_thought] dreams about", "like", "are", "have [get_far_thought] thoughts about", "strategize on","plot on","talk about","make [get_far_thought] rap about","make [get_far_thought] free styles about",
                "make [get_nano_modify] songs about","reminisce about","have [get_far_thought] memories of","have [get_far_thought] discussions about","contemplate","write [get_a_nano_modify] book about","love","have far thoughts about",
                "start a shadow idea about","know the effect with out knowing the meaning of","see a shadow coincidence when",
            "testify about","were","write [get_a_nano_modify] report about","have perfect thought disorder when"};
            string str = pick(bitbrainkillersdoing_list);
            return str;
        }
        public static string bitbrainkillerdoing()
        {
            string str = get_aspercream();
            str += bitbrainkillerdoing_x();
            str += call(bitbrainkillerdoinglist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainkillerfemaledoing()
        {
            string str = get_aspercream_bitch();
            str += bitbrainkillerdoing_x();
            str += call(bitbrainkillerfemaledoinglist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainkillerdoing_x()
        {
            string[] bitbrainkillerdoing_list = new string[] { "has [get_far_thought] dreams about", "likes", "is", "has [get_far_thought] thoughts about", "strategizes on","plots on","talks about","makes [get_far_thought] rap about","makes [get_far_thought] free style about",
                "makes [get_nano_modify] songs about", "reminisces about","has [get_far_thought] memories of","has [get_far_thought] discussions about","contemplates","writes [get_a_nano_modify] book about","loves","has far thoughts about",
                "starts a shadow idea about","knows the effect with out knowing the meaning of",
                "testifies about","was","writes [get_a_nano_modify] report about","sees a shadow coincidence when","has perfect thought disorder when"
            };
            string str = pick(bitbrainkillerdoing_list);
            return str;
        }

        public static string bitbrainkillerwill()
        {
            string str = get_aspercream();
            str += bitbrainkillerwill_x();
            str += call(bitbrainkillerwilllist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrainkillerfemalewill()
        {
            string str = get_aspercream_bitch();
            str += bitbrainkillerwill_x();
            str += call(bitbrainkillerfemalewilllist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrainkillerwill_x()
        {
            string[] bitbrainkillerwill_list = new string[] { "will", "wants to",  "makes [get_nano_modify] plans to", "tries to", "gets into position to", "prepares to", "gets ready to",
                "makes [get_a_nano_modify] conspiracy to","makes [get_a_nano_modify] memo to","gives [get_a_nano_modify] order to" };
            string str = pick(bitbrainkillerwill_list);
            return str;
        }
        public static string bitbrainkillerswill()
        {
            string str = get_aspercreams();
            str += bitbrainkillerswill_x();
            str += call(bitbrainkillerswilllist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrainkillerfemaleswill()
        {
            string str = get_aspercream_bitches();
            str += bitbrainkillerswill_x();
            str += call(bitbrainkillerfemalewilllist);
            str += get_time_or_place_or_neither();
            return str;
        }
        public static string bitbrainkillerswill_x()
        {
            string[] bitbrainkillerswill_list = new string[] { "will", "want to", "make [get_nano_modify] plans to", "try to", "get into position to", "prepare to", "get ready to",  "make [get_a_nano_modify] conspiracy to",
            "make [get_a_nano_modify] memo to","give [get_a_nano_modify] order to"};
            string str = pick(bitbrainkillerswill_list);
            return str;
        }

        public static string bitbrainswill()
        {
            string str = get_bitbrains();
            str += bitbrainswill_x();
            str += call(bitbrainwilllist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainswill_x()
        {
            string[] bitbrainswill_list = new string[] { "will", "want to", "make [get_bit_modify] plans to", "try to", "get into position to", "prepare to", "get ready to",  "make [get_a_bit_modify] conspiracy to",
            "make [get_a_bit_modify] memo to"};
            return pick(bitbrainswill_list);
        }
        public static string bitbrainwill()
        {
            string str = get_bitbrain();
            str += bitbrainwill_x();
            str += call(bitbrainwilllist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainwill_x()
        {
            string[] bitbrainwill_list = new string[] { "will", "wants to", "makes [get_bit_modify] plans to", "tries to", "gets into position to", "prepares to", "gets ready to",  "makes [get_a_bit_modify] conspiracy to",
            "makes [get_a_bit_modify] memo to"};
            return pick(bitbrainwill_list);
        }


        public static string bitbrainkillerdoes()
        {
            string str = get_aspercream();
            str += call(bitbrainkillerdoeslist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string bitbrainkillerfemaledoes()
        {
            string str = get_aspercream_bitch();
            str += call(bitbrainkillerfemaledoeslist);
            str += get_time_or_place_or_neither();
            return str;
        }

        public static string doingtobitbrains()
        {
            string[] rodeon_list = new string[] { "riding on", "blasting on", "rolling up on", "banging on", "balling on", "riding against", "balling against", "going to war against",
                "hanging up [get_a_nano_modify] phone on","hanging","lynching","hitting up","pistol whipping","smoking","fighting","brawling with","[get_nano_modify] styling against",
                "picking a fight with","fucking with","stabbing","hurting","bombing","stomping","kicking","punching","blowing up",
                "breaking the head of","busting on","killing","burying","breaking the [get_bit_modify] ass of","wetting","cock blocking","choking","castrating","handcuffing","tying up",

            };
            string str;
            str = pick(rodeon_list);
            str += get_a_bitbrain_or_bitbrains();
            return str;
        }
        public static string doingtobitbrains2()
        {
            string[] doing_list = new string[] { "pistol whipping [get_a_bitbrain_or_bitbrains] with [get_handgun]","hanging [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] rope",
            "[get_nano_modifying] [athingplaceortime]","putting [get_a_bitbrain_or_bitbrains] on trial for [get_bit_modifying]","hanging [get_a_bitbrain_or_bitbrains] from [get_a_nano_modify] tree",
            "feeding [get_a_bitbrain_or_bitbrains] to [get_animal_or_animals]","practicing [get_nano_modify] styling","using [get_a_nano_modify] color combination light sabre on [get_a_bitbrain_or_bitbrains]",
            "ripping [get_bitbrain_s] head off and bitting down it's neck","hitting [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] cattle prod",
            "making [get_nano_modify] geography lessons","riding in [get_a_nano_modify] g-ride","flossing on [get_a_bitbrain_or_bitbrains]","getting high off [get_nano_modify] marijuana",
            "following the [get_nano_modify] rules of the streets",
            };

            string str;
            str = pick(doing_list);
            return str;
        }


        public static string doingtobitbrainwhores()
        {
            string[] doing_list = new string[] { "",
            };

            string str;
            str = pick(doing_list);
            return str;
        }
        public static string bitbrainkillerdoingtobitbrainkillerfemale()
        {
            string[] doing_list = new string[] { "marrying [get_aspercream_bitch_or_bitches]","dating [get_aspercream_bitch_or_bitches]","wining and dining [get_aspercream_bitch_or_bitches]","dancing with [get_aspercream_bitch_or_bitches]",
                "[get_nano_modify] styling with [get_aspercream_bitch_or_bitches]","vacationing with [get_aspercream_bitch_or_bitches]","watching [get_a_nano_modify] movie with [get_aspercream_bitch_or_bitches]",
                "making [get_nano_modify] love to [get_aspercream_bitch_or_bitches]",

            };

            string str;
            str = pick(doing_list);
            return str;
        }
        public static string bitbrainkillersdoingtobitbrainkillerfemales()
        {
            string[] doing_list = new string[] { "marrying [get_aspercream_bitches]","dating [get_aspercream_bitches]","wining and dining [get_aspercream_bitches]","dancing with [get_aspercream_bitches]",
                "[get_nano_modify] styles with [get_aspercream_bitches]","vacationing with [get_aspercream_bitches]","watching [get_a_nano_modify] movie with [get_aspercream_bitches]","making [get_nano_modify] love to [get_aspercream_bitches]",
            };

            string str;
            str = pick(doing_list);
            return str;
        }
        public static string didtobitbrains()
        {
            string[] rodeon_list = new string[] { "rode on", "blasted on", "rolled up on", "banged on", "balled on", "rode against", "balled against", "went to war against",
            "hung up [get_a_nano_modify] phone on","hung","lynched","hit up","pistol whipped","smoked","fought","brawled with","[get_nano_modify] styled against",
                "picked a fight with","fucked with","stabbed","hurt","bombed","stomped","kicked","punched","blowed up",
                "broke the head of","busted on","killing","buried","broke the [get_bit_modify] ass of","wet up","cock blocked","choked","castrated","handcuffed","tied up"
            };

            string str;
            str = pick(rodeon_list);
            str += get_a_bitbrain_or_bitbrains();
            return str;
        }

        public static string didtobitbrains2()
        {
            string[] did_list = new string[] { "pistol whipped [get_a_bitbrain_or_bitbrains] with [get_handgun]","hung [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] rope",
            "[get_nano_modified] [athingplaceortime]","put [get_a_bitbrain_or_bitbrains] on trial for [get_bit_modifying]","hung [get_a_bitbrain_or_bitbrains] from [get_a_nano_modify] tree",
            "fed [get_a_bitbrain_or_bitbrains] to [get_animal_or_animals]","used [get_a_nano_modify] color combination light sabre on [get_a_bitbrain_or_bitbrains]",
            "ripped [get_bitbrain_s] head off and bitted down it's neck","hit [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] cattle prod",
            "made [get_nano_modify] geography lessons","rode in [get_a_nano_modify] g-ride","flossed on [get_a_bitbrain_or_bitbrains]","got high off [get_nano_modify] marijuana",
            "followed the [get_nano_modify] rules of the streets",};

            string str;
            str = pick(did_list);
            return str;
        }

        public static string didtobitbrainwhores()
        {
            string[] did_list = new string[] { "",
            };
            string str;
            str = pick(did_list);
            return str;
        }
        public static string bitbrainkillerdidtobitbrainkillerfemale()
        {
            string[] doing_list = new string[] { "married [get_aspercream_bitch_or_bitches]","dated [get_aspercream_bitch_or_bitches]","wined and dined [get_aspercream_bitch_or_bitches]","danced with [get_aspercream_bitch_or_bitches]","[get_nano_modify] styled with [get_aspercream_bitch_or_bitches]",
                "vacationed with [get_aspercream_bitch_or_bitches]","watched [get_a_nano_modify] movie with [get_aspercream_bitch_or_bitches]","made [get_nano_modify] love to [get_aspercream_bitch_or_bitches]",
            };

            string str;
            str = pick(doing_list);
            return str;
        }

        public static string bitbrainkillersdidtobitbrainkillerfemales()
        {
            string[] doing_list = new string[] { "married [get_aspercream_bitches]","dated [get_aspercream_bitches]","wined and dined [get_aspercream_bitches]","danced with [get_aspercream_bitches]","[get_nano_modify] styled with [get_aspercream_bitches]",
                "vacationed with [get_aspercream_bitches]","watched [get_a_nano_modify] movie with [get_aspercream_bitches]","made [get_nano_modify] love to [get_aspercream_bitches]",
            };
            string str;
            str = pick(doing_list);
            return str;
        }

        public static string doestobitbrains()
        {
            string[] rideson_list = new string[] { "rides on", "blasts on", "rolls up on", "bangs on", "balls on", "rides against", "balls against", "goes to war against",
            "hangs up [get_a_nano_modify] phone on","hangs","lynches","hits up","pistol whips","smokes","fights","brawls with","[get_nano_modify] styles against",
                "picks a fight with","fucks with","stabs","hurts","bombs","stomps","kicks","punches","blows up",
                "breaks the head of","busts on","kills","buries","breaks the [get_bit_modify] ass of","wets up","cock blocks","chokes","castrates","handcuffs","ties up"

            };
            string str;
            str = pick(rideson_list);
            str += get_a_bitbrain_or_bitbrains();
            return str;
        }

        public static string doestobitbrains2()
        {
            string[] does_list = new string[] { "pistol whips [get_a_bitbrain_or_bitbrains] with [get_handgun]", "hangs [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] rope",
            "[get_nano_modifies] [athingplaceortime]","puts [get_a_bitbrain_or_bitbrains] on trial for [get_bit_modifying]","hangs [get_a_bitbrain_or_bitbrains] from [get_a_nano_modify] tree",
            "feeds [get_a_bitbrain_or_bitbrains] to [get_animal_or_animals]","uses [get_a_nano_modify] color combination light sabre on [get_a_bitbrain_or_bitbrains]",
            "rips [get_bitbrain_s] head off and bits down it's neck","hits [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] cattle prod",
            "makes [get_nano_modify] geography lessons","rides in [get_a_nano_modify] g-ride","flosses on [get_a_bitbrain_or_bitbrains]","gets high off [get_nano_modify] marijuana",
            "follows the [get_nano_modify] rules of the streets",};

            string str;
            str = pick(does_list);
            return str;
        }
        public static string doestobitbrainwhores()
        {
            string[] does_list = new string[] { "",
            };

            string str;
            str = pick(does_list);
            return str;
        }
        public static string bitbrainkillerdoestobitbrainkillerfemale()
        {
            string[] doing_list = new string[] { "marries [get_aspercream_bitch_or_bitches]","dates [get_aspercream_bitch_or_bitches]","wines and dines [get_aspercream_bitch_or_bitches]","dances with [get_aspercream_bitch_or_bitches]","[get_nano_modify] styles with [get_aspercream_bitch_or_bitches]",
                "vacations with [get_aspercream_bitch_or_bitches]","watches [get_a_nano_modify] movie with [get_aspercream_bitch_or_bitches]","makes [get_nano_modify] love to [get_aspercream_bitch_or_bitches]",
            };

            string str;
            str = pick(doing_list);
            return str;
        }

        public static string dotobitbrains()
        {
            string[] rideon_list = new string[] { "ride on", "blast on", "roll up on", "bang on", "ball on", "ride against", "ball against", "go to war against",
            "hang up [get_a_nano_modify] phone on","hang","lynch","hit up","pistol whip","smoke","fight","brawl with","[get_nano_modify] style against",
                "pick a fight with","fuck with","stab","hurt","bomb","stomp","kick","punch","blow up",
                "break the head of","bust on","kill","bury","break the [get_bit_modify] ass of","wet up","cock block","choke","castrate","handcuff","tie up"
            };
            string str;
            str = pick(rideon_list);
            str += get_a_bitbrain_or_bitbrains();
            return str;
        }

        public static string dotobitbrains2()
        {
            string[] do_list = new string[] { "pistol whip [get_a_bitbrain_or_bitbrains] with [get_handgun]", "hang [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] rope",
            "[get_nano_modify] [athingplaceortime]","put [get_a_bitbrain_or_bitbrains] on trial for [get_bit_modifying]","hang [get_a_bitbrain_or_bitbrains] from [get_a_nano_modify] tree",
            "feed [get_a_bitbrain_or_bitbrains] to [get_animal_or_animals]","use [get_a_nano_modify] color combination light sabre on [get_a_bitbrain_or_bitbrains]",
            "rip [get_bitbrain_s] head off and bit down it's neck","hit [get_a_bitbrain_or_bitbrains] with [get_a_nano_modify] cattle prod",
            "make [get_nano_modify] geography lessons","ride in [get_a_nano_modify] g-ride","floss on [get_a_bitbrain_or_bitbrains]","get high off [get_nano_modify] marijuana",
            "follow the [get_nano_modify] rules of the streets",};

            string str;
            str = pick(do_list);
            return str;
        }
        public static string dotobitbrainwhores()
        {
            string[] do_list = new string[] { "",
            };

            string str;
            str = pick(do_list);
            return str;
        }

        public static string bitbrainkillerdotobitbrainkillerfemale()
        {
            string[] doing_list = new string[] { "marry [get_aspercream_bitch_or_bitches]","date [get_aspercream_bitch_or_bitches]","wine and dine [get_aspercream_bitch_or_bitches]","dance with [get_aspercream_bitch_or_bitches]","[get_nano_modify] style with [get_aspercream_bitch_or_bitches]",
                "vacation with [get_aspercream_bitch_or_bitches]","watch [get_a_nano_modify] movie with [get_aspercream_bitch_or_bitches]","make [get_nano_modify] love to [get_aspercream_bitch_or_bitches]",
            };

            string str;
            str = pick(doing_list);
            return str;
        }

        public static string bitbrainkillersdotobitbrainkillerfemales()
        {
            string[] doing_list = new string[] { "marry [get_aspercream_bitches]","date [get_aspercream_bitches]","wine and dine [get_aspercream_bitches]","dance with [get_aspercream_bitches]","[get_nano_modify] style with [get_aspercream_bitches]",
                "vacation with [get_aspercream_bitches]","watch [get_a_nano_modify] movie with [get_aspercream_bitches]","make [get_nano_modify] love to [get_aspercream_bitches]",
            };

            string str;
            str = pick(doing_list);
            return str;
        }

        public static string DuplicateInfo = "";

        public static string pick(string[] arr)
        {
            Dictionary<string, string> dupe_dict = new Dictionary<string, string>();

            foreach (string s in arr)
            {
                string s2 = s.Replace(" ", "");
                if (!s2.Contains("[") && !s2.Contains("{"))
                {
                    if (dupe_dict.ContainsKey(s2))
                    {
                        StackTrace st = new StackTrace(true);
                        StackFrame sf = st.GetFrame(1);
                        string stackname = sf.GetMethod().Name;
                        DuplicateInfo += "@ " + stackname + " array has duplicate: " + s2 + Environment.NewLine;
                    }
                    else
                    {
                        dupe_dict.Add(s2, s2);
                    }
                }
            }
            
            int t;
            t = RandomNumber.Rand4(arr.Length);

            if (arr[t].Length > 1 && arr[t][arr[t].Length - 1] == ' ')
            {
                return arr[t];
            }
            return arr[t] + " ";
        }

        public static string call(nanodels[] nanodels1)
        {
            return nanodels1[RandomNumber.Rand4(nanodels1.Length)]();
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

        public static string[] far_thought_list = new string[] {"G. Therm","Gold Pyramid","non sense non sense sense is your ass killed", "E1 point 0E", "twice the effect with out the meaning","far thought","pure sense","perfect thought disorder",
            "you cause you","not finished i have to laugh","green pyramids","shadow coincidence","evacuate green line","I know the effect with out knowing the meaning","things not things","long way out",
            "green even when he's red","269 Chess A Dee","shadow idea","green","frog","scorpion","dracula"};

        public static string[] religion_mofos = new string[] { "catholic", "jewish", "amish", "protestant", "buddhist", "hindu" };

        public static string[] place_mofos = new string[] { "american", "european", "indian", "chinese", "japanese", "north american", "middle eastern", "australian", "asian", "south side", "north side",
            "west side", "east side" };

        public static string[] bitch_s = new string[] {  "girl's", "chick's", "sister's",
                "lady's", "woman's", "wife's", "girl friend's", "fiancé's","bitch's","sluts","hoes","prom queen's","princess'","queen's" };

        public static string[] bitches = new string[] {  "girls", "chicks", "sisters",
                "ladies", "women", "wives", "girl friends", "fiancés","bitches","sluts","hoes","prom queens","princesses","queens" };


        public static string[] bitch = new string[] {  "girl", "chick", "sister",
                "lady", "woman", "wife", "girl friend", "fiancé","bitch","slut","hoe","prom queen","princess","queen" };

        public static string[] handgun = new string[] { "gun", "heater", "pistol", "nine millimeter", "four five", "M nineteen eleven", "revolver", "saturday night special", "artillery piece" };
        public static string[] handguns = new string[] { "guns", "heaters", "pistols", "nine millimeters", "four fives", "M nineteen elevens", "revolvers", "saturday night specials", "artillery pieces" };
        public static string[] gun = new string[] { "AK forty seven", "M sixteen", "M4" };
        public static string[] guns = new string[] { "AK forty sevens", "M sixteens", "M fours" };
        public static string[] food_list = new string[] {"apple","ice cream cone","banana split","rib eye","cowboy ribeye","filet mignon","pork chop","blooming onion","chicken wing","taco","taco salad","stew","roast",
        "hamburger","cheese burger","sushi roll","bowl of curry chicken","plate of vindaloo lamb","lamb chop","piece of fried chicken","watermelon","orange","banana","lobster","pizza","plate of pasta"};
        public static string[] foods_list = new string[] {"apples","ice cream cones","banana splits","rib eyes","cowboy ribeyes","filet mignons","pork chops","blooming onions","chicken wings","tacos","taco salads","stew","roasts",
        "hamburgers","cheese burgers","sushi rolls","bowls of curry chicken","plates of vindaloo lamb","lamb chops","fried chicken","watermelons","oranges","bananas","lobsters","crab cakes","pizzas"};

        public static string get_far_thought_list()
        {
            return pick(far_thought_list);
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
            return pick(food_list);
        }
        public static string get_food_lists()
        {
            return pick(foods_list);
        }
        public static string get_handgun()
        {
            string str = get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return get_a(str + pick(handgun));
        }
        public static string get_handguns()
        {
            string str = get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return str + pick(handguns);
        }
        public static string get_guns()
        {
            string str = "";
            str += get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return str + pick(guns.Concat(handguns).ToArray());
        }
        public static string get_gun()
        {
            string str = "";
            str += get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return str + pick(gun.Concat(handgun).ToArray());
        }
        public static string geta_gun()
        {
            string str = "";
            str += get_nano_modify();
            if (RandomNumber.Rand4(2) == 0)
            {
                str += "government ";
            }
            return get_a(str + pick(gun));
        }
        public static string get_bit_modifying()
        {
            return pick(bit_modifying);
        }
        public static string get_bit_modifies()
        {
            return pick(bit_modifies);
        }
        public static string get_bit_modified()
        {
            return pick(bit_modified);
        }
        public static string get_bit_modify()
        {
            return pick(bit_modify);
        }
        public static string get_a_bit_modify()
        {
            return get_a(pick(bit_modify));
        }
        public static string get_bit_modify_y()
        {
            return pick(bit_modify_y);
        }
        public static string get_a_nano_modify()
        {
            return get_a(get_nano_modify());
        }
        public static string get_nano_modify()
        {
            return pick(nano_modify);
        }
        public static string get_nano_modified()
        {
            return pick(nano_modified);
        }
        public static string get_nano_modify_y()
        {
            return pick(nano_modify_y);
        }
        public static string get_nano_modifies()
        {
            return pick(nano_modifies);
        }
        public static string get_nano_modifying()
        {
            return pick(nano_modifying);
        }
        public static string get_aspercream_bitch()
        {
            return get_a(get_aspercream_mofos(bitch));
        }

        public static string[] aspercreammofo = new string[] { "man", "boy", "police officer", "gangster", "baller", "player", "outlaw", "lawyer", "rapper", "country singer", "mother fucker", "son of a bitch", "person",
            "mobster", "enforcer", "hitman","drug dealer","naval aviator","navy SEAL","G","husband","dictator","god king","president","pope","hang man","executioner","bitbrain killer",
        "[get_nano_modify] styler","killer","rider","drug kingpin","soldier","government agent","mafia don","nano prisoner","cow boy","movie star","aristocrat","lord",
        "prince","king","general","admiral","gentleman","president of Nanopol","Nanopol officer","F.B.I. Agent","C.I.A. agent","N.S.A. agent","microsoft employee","jedi knight","sith lord","hustler","space pirate","astronaut",
        "nano dungeon naut","basket ball player","football player","alien","monster","stranger","demon","angel","prophet","clairvoyant","psychic","detective","mercenary","ghost","nomad","assassin","emperor",
        "submarine captain","wizard","warlock","magician","necromancer","sorcerer","dragon","troll","seventh son of a seventh son","mystic","incubus","indian","cave man",
        "barbarian","starship captain","comedian","politician","judge","journalist","warrior","godzilla","adventurer","prince of {the nanodungeon of doom,darkness}","time traveler","little green man","gray","revolutionary","knight",
        "duke","spartan warrior","prisoner","guard","inmate","driver","white knight","pilgrim","private","davy jones","darth vader","genie","hero","pirate","ninja","sniper","dark lord","god","rebel","privateer","buccaneer",
        "daredevil","swashbuckler","baron","commander","don","overlord","ruler","seer","shaman","secret agent","cyborg","robot","terminator","boss player","shot caller","thug","rap star","ghetto star","mack","mack daddy","Lo Pan","storm",
        "thunder","crom","juggalo","nano dungeon of doom star","centaur"

        
        };
        

        public static string get_no_a_aspercream()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_aspercream_mofos(aspercreammofo) : pick(aspercream);
        }

        public static string get_a_aspercream()
        {
            return get_a(get_aspercream_mofos(aspercreammofo));
        }
        public static string get_aspercream()
        {                    
            return (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(aspercreammofo)) : pick(aspercream);
        }
        public static string get_aspercreaming()
        {
            string[] mofoing = new string[] { "manning", "boying", "police officering", "gangstering", "ballering", "playering", "outlawing", "lawyering", "rappering", "country singering", "mother fuckering", "son of a bitching", "personing",
            "mobstering", "enforcering", "hitmanning","drug dealering","playering","shot callering","naval aviatoring","navy SEALing","Gee-ing","husbanding","dictatoring","god kinging","presidenting","poping",
        "hang manning","executionering","bitbrain killering",
        "[get_nano_modify] stylering","killering","ridering","drug kingpining","soldiering","government agenting","mafia donning","nano prisonering","cow boying","movie starring","aristocratting","lording",
        "princing","kinging","generalling","admiralling","gentlemanning","president of Nanopoling","Nanopol officering","F.B.I. Agenting","C.I.A. agenting","N.S.A. agenting","microsoft employee-ing","jedi knighting","sith lording","starship captaining",
        "hustlering","space pirating","cromming","centauring"};
            return (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(mofoing)) : pick(aspercreaming);
        }
        public static string get_aspercream_s()
        {
            string[] mofo_s = new string[] { "man's", "boy's", "police officer's", "gangster's", "baller's", "player's", "outlaw's", "lawyer's", "rapper's", "country singer's", "mother fucker's",
            "son of a bitch's", "mobster's", "enforcer's", "hitman's","drug dealer's","player's","shot caller's","naval aviator's","navy SEAL's","Gee's","husband's","god king's","president's","pope's","hang man's","executioner's",
        "bitbrain killer's","[get_nano_modify] styler's","killer's","rider's","drug kingpin's","soldier's","government agent's","mafia don's","nano prisoner's","cow boy's","movie star's","aristocrat's","lord's",
        "prince's","king's","general's","admiral's","gentleman's","Nanopol officer's","president of Nanopol's","F.B.I. Agent's","C.I.A. agent's","N.S.A. agent's","microsoft employee's","jedi knight's","sith lord's","starship captain's",
        "hustler's","space pirate's","astronaut's","warrior's","nano dungeon naut's","basket ball player's","football player's","alien's","monster's","stranger's","demon's","angel's","prophet's","clairvoyant's","psychic's","detective's",
                "mercenary's","ghost's","nomad's","assassin's","emperor's","dictator's",
        "submarine captain's","wizard's","warlock's","magician's","necromancer's","sorcerer's","dragon's","troll's","seventh son of a seventh son's","mystic's","incubus'","freddy krueger's","jason voorhees's","king kong's","cowboy's","indian's",
                "cave man's","barbarian's","starship captain's","comedian's","politician's","judge's","president's","journalist's","warrior's","godzilla's","adventurer's","prince of darkness'","time traveler's","little green man's","gray's","revolutionary's","knight's",
        "duke's","spartan warrior's","prisoner's","guard's","inmate's","driver's","genie's","hero's","boss player's","shot caller's","thug's","rap star's","ghetto star's","mack's","mack daddy's","crom's","juggalo's",
        "nano dungeon of doom's star's","centaur's"
        };
            return (RandomNumber.Rand4(2) == 0) ? get_a(get_aspercream_mofos(mofo_s)) : pick(aspercream_s);
        }
        public static string get_aspercream_any()
        {
            return RandomNumber.Rand4(2) == 0 ? get_aspercream_bitch_or_bitches() : get_aspercream_or_aspercreams();
        }
        public static string get_aspercream_mofos_or_bitches()
        {
            return RandomNumber.Rand4(2) == 0 ? get_aspercreams() : get_aspercream_mofos(bitches);
        }
        public static string get_aspercream_bitch_or_bitches()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_aspercream_bitch() : get_aspercream_mofos(bitches);
        }
        public static string get_aspercream_mofos(string[] aspercream_array)
        {
            StringBuilder str = new StringBuilder();
            str.Append(pick(far_thought_list));
            str.Append(get_mofo_meta());
            str.Append(pick(aspercream_array));
            return str.ToString();
        }
        public static string get_mofo_meta()
        {
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(pick(place_mofos));
            }
            if (RandomNumber.Rand4(4) == 0)
            {
                str.Append(pick(religion_mofos));
            }
            return str.ToString();
        }
        public static string get_aspercreams()
        {
            string[] mofos = new string[] { "men", "boys", "police officers", "gangsters", "ballers", "players", "outlaws", "lawyers", "rappers", "country singers", "mother fuckers", "sons of bitches",
            "people", "mobsters", "enforcers", "hitmen","drug dealers","players","shot callers","naval aviators","navy SEALs","Gees","husbands","dictators","presidents","hang men","executioners","bitbrain killers",
        "[get_nano_modify] stylers","killers","riders","drug kingpins","soldiers","government agents","mafia dons","nano prisoners","cow boys","movie stars","aristocrats","lords",
        "princes","kings","generals","admirals","gentlemen","Nanopol officers","F.B.I. Agents","C.I.A. agents","N.S.A. agents","microsoft employees","jedi knights","sith lords","hustlers","space pirates","astronauts","warriors",
        "nano dungeon nauts","basket ball players","football players","aliens","monsters","strangers","demons","angels","prophets","clairvoyants","psychics","detectives","mercenaries","ghosts","nomads","assassins","kings","emperors","popes",
        "submarine captains","wizards","warlocks","magicians","necromancers","sorcerers","dragons","trolls","seventh sons of seventh sons","mystics","cowboys","indians","cave men","barbarians","starship captains","comedians","politicians",
                "judges","journalists","warriors","adventurers","time travelers","little green men","grays","revolutionaries","knights","dukes","spartan warriors","prisoners","guards","inmates","drivers","grim reapers","genies","heroes",
                "robots","cyborgs","terminators","boss players","thugs","juggalos","nano dungeon of doom stars"

        };
            return get_aspercream_mofos(mofos);
        }

        public static string get_aspercream_or_aspercreams()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_aspercreams() : get_aspercream();
        }
        public static string get_no_a_bitbrain()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_bitbrain_mofo(bitbrain_mofo.Concat(bitch).ToArray()) : pick_bitbrain(bitbrain);
        }
        public static string get_bitbrain()
        {

            return (RandomNumber.Rand4(2) == 0) ? get_a(get_bitbrain_mofo(bitbrain_mofo.Concat(bitch).ToArray())) : get_a(pick_bitbrain(bitbrain));

        }
        public static string get_bitbrains()
        {
            return (RandomNumber.Rand4(2) == 0) ? get_bitbrain_mofo(bitbrain_mofos.Concat(bitches).ToArray()) : pick_bitbrain(bitbrains);
        }
        public static string get_bitbrain_s()
        {

            return (RandomNumber.Rand4(2) == 0) ? get_a(get_bitbrain_mofo(bitbrain_mofo_s.Concat(bitch_s).ToArray())) : get_a(pick_bitbrain(bitbrain_s));

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
                str.Append(pick(mental));
            }
            str.Append(pick(bitbrain_array));
            return str.ToString();
        }
        public static string[] bitbrain_mofo = new string[] { "mother fucker", "son of a bitch", "whore", "bastard", "bitler",
            "bit hole", "bit holer" };
        public static string[] bitbrain_mofos = new string[] { "mother fuckers", "sons of bitches", "whores","bastards", "bitlers",
            "bit holes", "bit holers" };
        public static string[] bitbrain_mofo_s = new string[] { "mother fucker's", "son of a bitch's", "whore's", "bastard's",
            "bitler's", "bit hole's", "bit holer's" };
        public static string[] aspercream = new string[] { "Aspercream", "The Bitbrain Killer", "Mister E1 point 0E", "Twice the effect with out the meaning", "the [get_far_thought] nano prisoner",
            "the president of [get_far_thought] Nanopol","[get_far_thought] James Gentilly", };
        public static string[] aspercreaming = new string[] { "Aspercreaming", "Bitbrain Killering", "Mister E1 point 0Eing", "Twice the effect with out the meaninging", "nano prisonering" };
        public static string[] aspercream_s = new string[] { "Aspercream's", "The Bitbrain Killer's", "Mister E1 point 0 ease", "Twice the effect with out the meaning's","the [get_far_thought] nano prisoner's",
            "the president of [get_far_thought] Nanopol's","[get_far_thought] James Gentilly's",};
        public static string get_bitbrain_mofo(string[] bitbrain_array)
        {
            StringBuilder str = new StringBuilder();            
            
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(pick(mental));
            }
            str.Append(pick(bit_modify));
            
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(get_mofo_meta());
            }
            str.Append(pick(bitbrain_array));
            return str.ToString();

        }

        public static string[] mental = new string[] { "lousy", "lousy little","country ass","nanodungeon ass","confused ass","dizzy ass",
            "punk ass","jealous ass","dumb ass","stupid ass","fake ass","weak ass","in bit","lying","mark ass","bitch ass" };

        public static string[] bitbrain = new string[] { "bitler","oner","zeroer","seven hundred megabyter","submariner","one bit per seconder","bit brain nano terrorist",
                "no mother fuckerer","no wayer","rebitted mother fucker","nano dungeoner","bitter","leafer","red facer",
            "bravo's racist fistser","european walking conspirator","bit brain","bit hole","bit holer",
        "louisiana brain deather","nano terrorist","redder"};

        public static string[] bitbrains = new string[] { "bitlers","oners","zeroers","seven hundred megabyters","submariners","one bit per seconders","bit brain nano terrorists",
                "no mother fuckerers","no wayers","rebitted mother fuckers","nano dungeoners","bitters","leafers","red facers",
            "bravo's racist fistsers","european walking conspirators", "bit brains","bit holes","bit holers",
        "louisiana brain deathers","nano terrorist","redders"};

        public static string[] bitbrain_s = new string[] { "bitler's","oner's","zeroer's","seven hundred megabyter's","submariner's","one bit per seconder's","bit brain nano terrorist's",
                "no mother fuckerer's","no wayer's","rebitted mother fucker's","nano dungeoner's","bitter's","leafer's","red facer's",
            "bravo's racist fistser's","european walking conspirator's", "bit brain's","bit hole's","bit holer's",
        "louisiana brain deather's","nano terrorist's","redder's"};


        public static string[] bit_modify = new string[] { "seven hundred megabytes","submarine","one bit per second","bit brain nano terrorist",
                "no mother fucker","no way","rebitted","nano dungeon","bit","leaf","red face",
            "bravo's racist fists","european walking conspiracy","red","one","zero"};

        public static string[] bit_modify_y = new string[] { "seven hundred megabyte-E","submarine-E","one bit per second-E","bit brain nano terrorist-E",
                "no mother fucker-E","no way-E","rebitted-E","nano dungeon-E","bit-E","leaf-E","red face-E",
            "bravo's racist fists-E","european walking conspiracy-E","reddy","one-E","zero-E"};


        public static string[] bit_modifies = new string[] { "seven hundred megabytes","submarines","one bit per seconds","bit brain nano terrorists",
                "no mother fuckers","no ways","rebits","nano dungeons","bits","leafs","red faces",
            "bravo's racist fists","european walking conspiracies","reds","ones","zeroes"};

        public static string[] bit_modified = new string[] { "seven hundred megabyted","submarined","one bit per seconded","bit brain nano terroristed",
                "no mother fuckered","no wayed","rebitted","nano dungeoned","bitted","leafed","red faced",
            "bravo's racist fistsed","european walking conspired","redded","oned","zeroed"};


        public static string[] bit_modifying = new string[] { "seven hundred megabyting","submarining","one bit per seconding","bit brain nano terroristing",
                "no mother fuckering","no waying","rebitting","nano dungeoning","bitting","red facing",
            "bravo's racist fistsing","european walking conspiracy-ing","redding","oneing","zeroing"};


        public static string[] nano_modifies = new string[] { "Gold Pyramids","G. Therms", "E one point zero ees","aspercreams","james is twice the effect with out the meanings","twice the effect with out the meaning","shadow idea",
                "pure senses","perfect thought disorders","far thoughts","shadow ideas","green pyramidses","you cause yous","shadow coincidences",
                "not finished i have to laughs","bit brains","louisiana brain deaths","seven hundred megabytes","submarines","one bit per seconds","bit brain nano terrorists",
                "no mother fuckers","no ways","2 6 9 chess A dees","evacuate green lines","rebits","bits","leafs",
            "things not things","long way outs","red faces","i know the effect with out knowing the meanings",
            "far thoughts","bossys","talk is nices","end conversation bores mes","scorpions","draculas","frogs",
            "green even when he's reds","bravo's racist fists","nano whores","european walking conspiracies","bossies","reds","greens","ones","zeroes"
            };
        public static string[] nano_modified = new string[] {  "Gold Pyramided","G. Thermed","E one point zero eed","aspercreamed","james is twice the effect with out the meaninged","twice the effect with out the meaninged","shadow ideaed",
                "pure sensed","perfect thought disordered","far thoughted","shadow ideaed","green pyramidsed","you cause you'ed","shadow coincidenced",
                "not finished i have to laughed","bit brained","louisiana brain deathed","seven hundred megabyted","submarined","one bit per seconded","bit brain nano terroristed",
                "no mother fuckered","no wayed","2 6 9 chess A deed","evacuate green lined","rebitted","bitted","leafed",
            "things not thingsed","long way outed","red faced","i know the effect with out knowing the meaninged",
            "bossied","talk is niced","end conversation bores me'ed","scorpioned","dracula-ed","frogged",
            "green even when he's reded","bravo's racist fisted","nano whored","european walking conspiracied","redded","greened","oned","zeroed"
            };
        public static string[] nano_modify = new string[] { "Gold Pyramid","G. Therm","bit brain killer","E1 point 0E","nonsense nonsense sense is your ass killed","aspercream",
                "james is twice the effect with out the meaning","twice the effect with out the meaning","i know the effect with out knowing the meaning",
                "pure sense","perfect thought disorder","far thought","shadow idea","green pyramids","you cause you","shadow coincidence",
                "not finished i have to laugh","bit brain","louisiana brain death","seven hundred megabytes","submarine","one bit per second","bit brain nano terrorist",
                "no mother fucker","no way","2 6 9 chess A dee","evacuate green line","rebitted","bit","leafs",
            "things not things","long way out","red face","bossy","talk is nice",
            "end conversation bores me","scorpion","dracula","frog","green even when he's red","bravo's racist fists",
            "nano whore","european walking conspiracy","red","green","one","zero" };

        public static string[] nano_modify_y = new string[] { "Gold Pyramidy","G. Thermy","bit brain killer-E","E1 point 0E-E","non sense non sense sense is your ass killed-E","aspercream-E",
                "james is twice the effect with out the meaning-E","twice the effect with out the meaning-E","i know the effect with out knowing the meaning-E",
                "pure sense-E","perfect thought disorder-E","far thought-E","shadow idea-E","green pyramids-E","you cause you-E","shadow coincidence-E",
                "not finished i have to laugh-E","bit brain-E","louisiana brain death-E","seven hundred megabyte-E","submarine-E","one bit per second-E","bit brain nano terrorist-E",
                "no mother fucker-E","no way-E","2 6 9 chess A dee E","evacuate green line-E","rebitted","bit-E","leaf-E",
            "things not things-E","long way out-E","red face-E","bossy-E","talk is nice-E",
            "end conversation bores me-E","scorpion-E","dracula-E","froggy","green even when he's red-E","bravo's racist fists-E",
            "nano whore-E","european walking conspiracy-E","reddy","greeny","one-E","zero-E" };

        public static string[] nano_modifying = new string[] { "Gold Pyramiding","G. Therming","bit brain killering","E one point zero E","non sense non sense sense is your ass killed-ing","aspercreaming",
                "james is twice the effect with out the meaning","twice the effect with out the meaning","i know the effect with out knowing the meaning",
                "pure sensing","perfect thought disordering","far thoughting","shadow ideaing","green pyramidsing","you cause you","shadow coincidencing",
                "not finished i have to laughing","bit braining","louisiana brain deathing","seven hundred megabyting","submarining","one bit per seconding","bit brain nano terroristing",
                "no mother fuckering","no waying","2 6 9 chess A deeing","evacuate green lining","rebitting","bitting","leafing",
            "things not thingsing","long way outting","red facing","talk is nicing",
            "end conversation bores me-ing","scorpioning","dracula-ing","frogging","green even when he's redding","bravo's racist fistsing",
            "nano whoring","european walking conspiracy-ing","bossying","redding","greening","oneing","zeroing"};


        public static string[] time = new string[] { "night", "day", "week", "month", "year", "time", "age", "era", "millennium", "century", "aeon", "eternity", "cycle" };
        public static string[] times = new string[] { "nights", "days", "weeks", "months", "years", "times", "ages", "eras", "millennia", "centuries", "aeons", "eternities", "cycles" };
        public static string[] modify_time_place = new string[] { "night mare", "merry", "new", "old", "ancient", "transcendental", "brave new" };
        public static string[] in_time = new string[] { "in", "during", "throughout" };
        public static string get_time_or_place_or_neither()
        {
            StringBuilder str = new StringBuilder();
            switch (RandomNumber.Rand4(5))
            {
                case 0:
                    str.Append(get_time() + get_place());
                    break;
                case 1:
                    str.Append(get_place() + get_time());
                    break;
                case 2:
                    str.Append(get_place());
                    break;
                case 3:
                    str.Append(get_time());
                    break;
                case 4:
                    break;
            }
            return str.ToString();
        }
        public static string get_time()
        {
            StringBuilder str = new StringBuilder();
            if (set_time == true) { return ""; }
            set_time = true;
            if (RandomNumber.Rand4(times.Length + 2) == 0) { return "all the damned time "; }
            if (RandomNumber.Rand4(times.Length + 2) == 0) { return "once in " + get_bitbrain_s() + "life time "; }
            if (set_place == false && (RandomNumber.Rand4(in_time.Length) == 0))
            {
                set_place = true;
                str.Append("somewhere in ");
            }
            else
            {
                str.Append(pick(in_time));
            }
            str.Append(get_time_no_in());
            return str.ToString();
        }
        public static string get_time_no_in()
        {
            set_time = true;
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append((RandomNumber.Rand4(2) == 0) ? "the " + get_time_no_inthe() : get_a(modifier_time_place() + get_nano_modify() + pick(time)));
            }
            else
            {
                str.Append("the " + modifier_time_place() + (RandomNumber.Rand4(2) == 0 ? pick(times) : pick(time)) + "of " + get_nano_modify());
            }
            return str.ToString();
        }
        public static string get_time_no_inthe()
        {
            set_time = true;
            StringBuilder str = new StringBuilder();
            str.Append(get_nano_modify() + (RandomNumber.Rand4(2) == 0 ? pick(times) : pick(time)));
            return str.ToString();
        }
        public static string geta_time_no_inthe()
        {
            set_time = true;
            StringBuilder str = new StringBuilder();
            if (RandomNumber.Rand4(2) == 0)
            {
                str.Append(get_nano_modify() + pick(times));
            }
            else
            {
                str.Append(get_a(get_nano_modify()) + pick(time));
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
                str.Append(pick(modify_time_place));
            }
            return str.ToString();
        }
        public static string[] placesa = new string[] {"hotel","palace","kingdom","igloo",
                "moon base","mars colony","star destroyer","nano utopia","u f o","submarine base","ballistic missile site","nuclear submarine","restaurant","space station","cd manufacturering plant",
        "submarine making facility","harem","space port","galaxy","solar system","chilis restaurant","outback restaurant","ruth chris restaurant","dragos restaurant","hilton hotel","Hyatt hotel", "Peppers restaurant",
        "buffalo wild wings restaurant","walmart","rouses","books-a-million","place","home","house","apartment","room","monastery","egyptian pyramid","doctor's office",
        "court room","jail","penitentiary","romulan warbird","bull bit farm","presidential suite","castle","village","town","city","ghetto","hood","hide out","state","ice castle","magical kingdom",
        "sanctuary","recording studio","music video","movie","court testimony","destroyer","P8-A submarine hunter","bedroom","living room","bathroom mirror","kitchen","garage",
        "summer camp","reality","nano dungeon","pre nano simulation","class room",
        "college","lecture hall","elementary school","neighborhood","mansion","police station","mall","yacht","museum","limousine","private jet",
        "jacuzzi","pool","garden","bath tub","shower","hotel room","bath room","missile boat","church","church of [get_aspercream]","shrine","temple","gas station","apartment building",
            "movie theatre",
        "library","supermarket","train station","party","weed circle","plantation","voice conspiracy",
        "styling contest","matrix","prom","wedding","office","lab","basement","attic","trailer park","trailer","university","high school","catholic school","convent","cabin","park","parking lot","brothel",
            "strip club","styling championship",
        "championship","hell","heaven","paradise","mountain","mountain hall","fountain of youth","afterlife","coincidence","republic","white house","worm hole","world trade center","circle of hell","jail cell","dream",
            "fantasy","utopia","country","world","conspiracy","dining room",
        

        };

        public static string[] placesthe = new string[] {"nano dungeon of doom","wild wild nano dungeon of doom","starship enterprise",
                "millennium falcon","white house","united nations building","chateau de versailles","emerald thai restaurant","southland mall","mall of america",
                "eiffel tower","taj mahal","big apple","kremlin","neuschwanstein castle","vatican","earth",
        "dinosaur park","streets","nano terrorists head quarters","bitbrain killers' head quarters","west side","east side","nanopol's headquarters","styling contest","catacombs","middle of nowhere","gates of tomorrow",
        "mountain","mountain hall","city of the {dead,mind raped}","internation space station","dimension","realm","spirit world","reality","shadow world","shadow realm","shadow dimension","shadow reality"
        };

        public static string[] places = new string[] { "land", "country", "county", "kcsr","america","europe","north america","south america","russia","china","japan","feudal japan","middle earth",
            "los angeles","chicago","dallas","new york","rome","paris","london","moscow","beijing","south central Los Angeles","new orleans","houma","tampa","central park","atlantis","camelot",
        "el dorado","shangri-la","mount olympus","zion","Transylvania"};

        public static string[] onplaces = new string[] { "Executor Star Destroyer", "golden state bridge", "wall of china", "History Channel", "Travel Channel","funny farm","bit farm","pirate ship","space shuttle" };

        public static string[] onaplaces = new string[] { "death star", "planet", "seven forty seven", "cargo ship", "nuclear submarine", "space ship", "school bus", "grey hound bus", "stage", "block", "sail boat","aircraft carrier",
        "tv channel","dyson sphere","ferris wheel"
        };

        public static string[] atplaces = new string[] { "angel falls", "egyptian pyramids", "end of a rainbow", "nano terrorists war crimes tribunal", "orgy", "nano center", "styling contest", "dinner table", "wedding", "prom", "white house", "pentagon" };
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
            if (RandomNumber.Rand4(6) == 0)
            {
                str.Append("somewhere ");
            }
            int[] t = { placesa.Length, placesthe.Length, places.Length, onplaces.Length, onaplaces.Length, atplaces.Length, 2 };
            switch (get_case(t))
            {
                case 5:
                    str.Append("at the " + modifier_time_place() + pick(nano_modify) + pick(atplaces));
                    break;
                case 3:
                    str.Append("on the " + modifier_time_place() + pick(nano_modify) + pick(onplaces));
                    break;
                case 0:
                    str.Append("in " + get_a((modifier_time_place() + pick(nano_modify) + pick(placesa))));
                    break;
                case 1:
                    str.Append("in the " + modifier_time_place() + pick(nano_modify) + pick(placesthe));
                    break;
                case 2:
                    str.Append("in " + pick(nano_modify) + pick(places));
                    break;
                case 4:
                    str.Append("on " + get_a(pick(nano_modify)) + pick(onaplaces));
                    break;
                case 6:
                    if (RandomNumber.Rand4(2) == 0)
                    {
                        str.Append("where [get_nano_modify] eagles dare");
                    }
                    else
                    {
                        str.Append("in mister rogers [get_bit_modify] nano dungeon of doom");
                    }
                    break;
            }
            return str.ToString();
        }
        public static string get_place_no_in()
        {
            set_place = true;
            StringBuilder str = new StringBuilder();
            int[] t = { placesa.Length, placesthe.Length, places.Length, onplaces.Length, onaplaces.Length, atplaces.Length, 1 };
            switch (get_case(t))
            {
                case 5:
                    str.Append("the " + modifier_time_place() + pick(nano_modify) + pick(atplaces));
                    break;
                case 3:
                    str.Append("the " + modifier_time_place() + pick(nano_modify) + pick(onplaces));
                    break;
                case 0:
                    str.Append(get_a((modifier_time_place() + pick(nano_modify) + pick(placesa))));
                    break;
                case 1:
                    str.Append("the " + modifier_time_place() + pick(nano_modify) + pick(placesthe));
                    break;
                case 2:
                    str.Append(pick(nano_modify) + pick(places));
                    break;
                case 4:
                    str.Append(get_a(pick(onaplaces)));
                    break;
                case 6:
                    str.Append("where [get_nano_modify] eagels dare");
                    break;
            }
            return str.ToString();
        }
        public static string athingplaceortime()
        {

            StringBuilder str = new StringBuilder();
            int t = -1;
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
            return get_a_nano_modify() + pick(athing);
        }
        public static string get_thing()
        {
            return pick(athing);
        }
        public static string get_bitbrain_thing()
        {
            return get_a_bit_modify() + pick(athing);
        }

        public static string[] athing = new string[] {"dinner","egg","seven forty seven","blunt","ufo",
                "oyster","joint","40 ounce","glass of rum","glass of scotch","jar of grey poupon","tie fighter","x-wing","beer","coffee","coffee table","poker game","gang","drug cartel",
                "submarine","college exam","knife","bank account","check","yacht","anaconda","lion","tiger","bear","polar bear","wolf","cobra","guillotine","eletric chair","cyanide pill","baseball bat",
                "jacuzzi","pool","garden","color combination light sabre","bath tub","shower","limousine","private jet","cigar","rose","machete","scorpion","snake","law of physics",
                "computer program","cat","dog","bottle of champagne","glass of champagne","cadillac","ferarri","lamborghini","bugatti veyron","number theory","computational theory","psychology theory","physics theory",
            "social theory","information theory",
                "T-Rex","velociraptor","allosaurus","mountain of gold","christmas tree","snow man","falling star","comet","dinosaur","crocodile","alien","bag of marijuana","nano bot","sea of madness",
                "car","g-ride","bk-ride","grabber blue ford mustang","suv","hooptie","64 impala","time machine","g ride","bk ride","circle of life","circle of hell","lie","fact","story","idea",
                "reason","style","butterfly effect","justification","justice","camp fire","sentence","paragraph","verse","judgement","election","ring","watch","vision","television","{smart,tele} phone",
                "computer","operating system","video game","song","box","hard drive","yoyo","bike","skate board","trampoline","pool table","washer","drier","refrigerator","cooler master nepton",
                "car engine","truck engine","car horn","helicopter","airplane","air conditioner","air conditioning vent","heater","water heater","myth","superstition","elixir","exlixir of life","unicorn horn",
                "magic lamp","genie","throne","dragon","troll","CD","sands of time","language","sword","spear","club","set of armor","bow","sling shot","symmetry","asymmetry","argument","conspiracy",
                "rule of the game","rule of engagement","speaker","computer speaker","A I","noise","electric chair","chair","sofa","soda","candy bar","quasar","black hole","star","nanobot","technological singularity",
                "army","navy","platoon","harpie","mermaid","oath of loyalty","cyborg","robot","matrioshka brain","jupiter brain","answering machine message","answering machine","telephone booth","pager","nintendo","commodore 64",
                "sega master system","heating vent","tv","ring of power","holy grail","lost ark","jewel","gem","diamond","hope diamond","space shuttle","international space station","worm hole",
                "world trade center","bomb","warp drive","teleporter","torpedo","nuclear submarine","missile boat","boomer","aircraft carrier","destroyer","depth charge","eternity","hell","heaven",
                "dynasty","empire","royal seal","dating service","realm","bong","dream","world","{black,[get_bit_modify] color combination} blood of the nanodungeon of doom",
                "burning blade","magic potion","wedding","graduation","secret society","emotion","sentiment","memory","prediction","relationship","love affair",
                "one night stand","marriage","life","vacation","honey moon","marriage proposal","sin","blood line","business","corporation","government",
                "[get_bit_modify] color combination blood of the nanodungeon of doom","abandoned truck","abandoned submarine","tape"




            };
        public static string thing()
        {

            string[] afarperson = new string[] { "jedi knight", "sith lord", "republican", "nano prisoner" };
            string[] aperson = new string[] { "pedestrian", "driver","truck driver", "starship enterprise crewman","man","woman","child","girl","boy","post man","tax man","computer programmer",
                "journalist","traffic cop","husband and wife","college student","lawyer","judge","wage slave","valet","alien","monster"
            };
            string[] abitperson = new string[] { "crack head", "communist","nano whore", "enemy","meth head","junkie","crack whore" };


            string[] thething = new string[] { "starship enterprise", "millennium falcon", "book of the mind raped","styling contest","nano game","U.S. government",
                "C I A","N S A","F B I","marine corps","N Y P D","L A P D","hope diamond","houma police department","association","club","organization","government","clan","group","think tank","news paper",
            "truth","peace","war","storm","calm","sacrificial lamb","logic system"};

            string[] bitbrainthing = new string[] { "face per cream", "car", "jail cell", "cd", "nano dungeon", "obituary", "ambition", "medical experiment",
                "show tech shot","trunk full of [get_bit_modify] bullshit","sickle cell anemia","trophy wife","dildo","teddy bear","diaper","{thought,brain,personality} disorder",
                "bull bit","drug trip","diapers","bit hole","communist mind conspiracy","nanoterrorist mind conspiracy"
            };

            string[] bitchthing = new string[] { "purse", "tampon", "panties", "pussy", "aspercream", "titties", "silk panties", "g-string", "bra", "wedding dress", "lips", "husband", "boyfriend", "prom dress", "pimply face per cream" };

            string[] notbitbrainthing = new string[] { "fist", "face per cream", "g-ride", "bk-ride", "heater", "cd", "free style", "rap", "P8-A sub hunter", "book of the mind raped", "mafia", "gang",
                "F-22","F-16","F-15","B2 Stealth Bomber","foot","eyes","family","marriage","job","circle of life","painting","crew","squad","cash stacks","life","computer",
            "jet ski","poem","song","talisman","good luck charm","watch","ring","ambition","honor","trophy","best friend","father","mother","sister","brother",
            "prophecy","destiny","fate","act of war","declaration of war","cease fire","peace treaty","book","movie","movie plot","autobiography",
            "personality","joke","comment","statement","quip","vow","constitution","manifesto","law","order","magic chest"
            };

            string[] bitbrainkillerthing = new string[] { "tuxedo", "wife", "girl friend", "marbles", "style", "trophy wife", "geography lessons", "map","military style judgement",
                "secretary style judgement","salad dressing",
                "kilos of cocaine","yacht","hotel","country","planet","galaxy","nano utopia","block","neighborhood","nuclear submarine","new born baby","best friend","face per cream",
                "prophecy","destiny","fate","style judgement","mind",
            "flesh","heart","life","crown","sceptre","chariot","treasure","treasure room","bit hole","passion","honor","bravery","loyalty","character","team","crew","family","love",
                "game","rap","free style","throne","dynasty","face","empire","love slave","circle","ambition","style","voice in his head"

            };
            
            StringBuilder str = new StringBuilder();

            switch (RandomNumber.Rand4(8))
            {
                case 0:
                    str.Append(get_a(get_aspercream_mofos(bitch_s) + get_far_thought_list() + pick(thething.Concat(notbitbrainthing).ToArray().Concat(bitchthing).ToArray().Concat(athing).ToArray().Concat(gun).ToArray().Concat(guns).ToArray().Concat(food_list).ToArray().Concat(foods_list).ToArray())));
                    break;
                case 1:
                    str.Append("the " + get_nano_modify() + pick(thething));
                    break;
                case 2:
                    str.Append(get_a(pick(nano_modify)) + pick(athing.Concat(food_list).ToArray().Concat(notbitbrainthing).ToArray().Concat(food_list).ToArray().Concat(foods_list).ToArray().Concat(guns).ToArray().Concat(gun).ToArray()));
                    break;
                case 3:
                    str.Append(get_a(get_bitbrain_mofo(bitbrain_mofo_s)) + get_bit_modify() + pick(bitbrainthing));
                    break;
                case 4:
                    str.Append(get_aspercream_s() + get_far_thought_list() + pick(thething.Concat(notbitbrainthing).ToArray().Concat(bitbrainkillerthing).ToArray().Concat(athing).ToArray().Concat(gun).ToArray().Concat(guns).ToArray().Concat(food_list).ToArray().Concat(foods_list).ToArray()));
                    break;
                case 5:
                    str.Append(get_a(pick(far_thought_list)) + pick(afarperson));
                    break;
                case 6:
                    str.Append(get_a(get_bit_modify()) + pick(abitperson));
                    break;
                case 7:
                    str.Append(get_a(get_nano_modify()) + pick(aperson));
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
            return get_a_nano_modify() + pick(animal);
        }
        public static string get_animals()
        {
            return get_nano_modify() + pick(animals);
        }
        public static string get_a_far_thought()
        {
            return get_a(get_far_thought_list());
        }

        public static string[] animal = new string[] { "shark", "velociraptor", "a T-Rex", "Allosaurus", "wolf", "bear", "polar bear", "lion", "crocodile", "tiger", "pit bull", "killer whale" };
        public static string[] animals = new string[] { "sharks", "velociraptors", "a T-Rexes", "Allosauruses", "wolves", "bears", "polar bears", "lions", "piranhas", "crocodiles", "tigers", "pit bulls", "killer whales" };

        public delegate string test();

        public static Dictionary<string, test> dels = new Dictionary<string, test>()
        {
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
            {"[get_food_list]",new test(get_food_list)},
            {"[get_foods_list]",new test(get_food_lists)},
            {"[get_bitbrain_bitches]",new test(get_bitbrain_bitches)},
            {"[get_a_nano_modify]",new test(get_a_nano_modify)},
            {"[get_nano_modify]",new test(get_nano_modify)},
            {"[get_nano_modify_y]",new test(get_nano_modify_y)},
            {"[get_nano_modifies]",new test(get_nano_modifies)},
            {"[get_nano_modified]",new test(get_nano_modified)},
            {"[get_nano_modifying]",new test(get_nano_modifying)},
            {"[get_time_no_in]",new test(get_time_no_in)},
            {"[geta_time_no_inthe]",new test(geta_time_no_inthe)},
            {"[get_time]",new test(get_time)},
            {"[get_aspercream_bitches]",new test(get_aspercream_bitches)},
            {"[get_place_no_in]",new test(get_place_no_in)},
            {"[get_place]",new test(get_place)},            
            {"[get_far_thought]",new test(get_far_thought_list)},
            {"[get_bitbrain_bitch_or_bitches]",new test(get_bitbrain_bitch_or_bitches)},
            {"[get_a_bitbrain_bitch]",new test(get_a_bitbrain_bitch)},
            {"[get_animal_or_animals]",new test(get_animal_or_animals)},
            {"[get_bitbrainmammy]",new test(get_bitbrainmammy)},
            {"[get_bitbrain_thing]",new test(get_bitbrain_thing) }
        };


        public static string[] bitbrainmammy = new string[] { "a doctor", "a judge", "a police officer", "a F.B.I. Agent", "the president", "their mammies" };
        public static string get_bitbrainmammy()
        {
            return pick(bitbrainmammy);
        }

        public static Boolean foundone = false;
        public static string replace_functions(string str)
        {
            string str2;
            int pos;            
            
            do
            {
                foundone = false;                                                
                foreach (KeyValuePair<string, test> kvp in dels)
                {
                    do
                    {
                        str = pickword(str);
                        pos = str.IndexOf(kvp.Key);
                        if (pos >= 0)
                        {
                            foundone = true;
                            str2 = dels[kvp.Key].Invoke().Replace(",", "");
                            str = str.Substring(0, pos) + str2 + str.Substring(pos + kvp.Key.Length);
                        }
                    } while (pos >= 0);
                }
            } while (foundone == true);
            while (str.Contains("  ")) str = str.Replace("  ", " ");
            return str;
        }
        public static string pickword(string str)
        {                       
            int pos, pos2, pos3;
            string s;
            pos = -1;
            do
            {
                pos = str.IndexOf("}");
                if (pos == -1)
                {
                    break;
                }
                pos3 = -1;
                do
                {
                    pos2 = str.IndexOf("{", pos3 == -1 ? 0 : pos3);
                    if (pos2 == -1)
                    {
                        break;
                    }
                    if (pos2 < pos)
                    {
                        pos3 = pos2 + 1;
                    }
                    else
                    {
                        break;
                    }
                } while (pos2 != -1);
                if (pos3 == -1)
                {
                    break;
                }
                s = str.Substring(pos3, pos - pos3);
                string[] sa = s.Split(new char[] { ',' });
                str = str.Substring(0, pos3 - 1) + pick(sa) + str.Substring(pos+1);
            } while (pos != -1);            
            return str;
        }

        public struct RandomNumber
        {

            public static byte[] random = new Byte[4];
            public static byte[] random2 = new Byte[random.Length * 4];
            public static uint test;
            public static System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            
            public static void compute()
            {
                rng.GetBytes(random);
                /*
                int i = 0;
                int r = 0;
                while (i < 20)
                {                    
                    for (int x = 0; x < random.Length; x++)
                    {
                        rng.GetBytes(random2);
                        random[x] = (byte)(random[x] ^ (byte)(random2[x * 4] + random2[(x * 4) + 1]));
                        random[x] = (byte)(random[x] + (byte)(random2[(x * 4) + 2] ^ random2[(x * 4) + 3]));
                        r += random[x];
                    }
                    i++;
                }
                r %= 10;
                r += 4;
                do
                {
                    byte b;
                    uint t,p;
                    rng.GetBytes(random2);
                    t = BitConverter.ToUInt32(random2, 0);
                    t %= 4;                    
                    do
                    {
                        rng.GetBytes(random2);
                        p = BitConverter.ToUInt32(random2, 0);
                        p %= 4;
                    } while (p == t);
                    b = random[t];
                    random[t] = random[p];
                    random[p] = b;
                    r--;
                } while (r > 0);
                */
            }

            public static Boolean initiated = false;
            public static int Rand4(int t, int r = -1)   // t==modulo r==last value, rejected.
            {                
                do
                {
                    compute();
                    test = System.BitConverter.ToUInt32(random, 0);
                    test = (test % (uint)t);
                } while (test == r);
                return (int)test;
            }
        }

    }
}