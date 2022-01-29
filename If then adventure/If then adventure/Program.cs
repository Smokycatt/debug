using System;


namespace adventure
{
    class Program
    {
        public static string Cfront { get; private set; }

        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("*A long time ago in a far off world of splender and magic of kaelonia the king calls apon you for a urgent mission becase you are a retired royal gaurds men *so now enter your username and begin the adventure:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();


            
            double life = 100;
            string room = "throne";
            int throneDone = 1;
            int CcoridorDone = 1;
            int CtreasureDone = 1;
            int EnemyHP1 = 50;
            int EnemyHP2 = 50;
            bool combat = true;
            int AC = 10;
            string AW = "2";
            int money = 13;
            string CfrontDone = "1";
            int House1Done = 1;
            int House2Done = 1;
            int House3Done = 1;
            int House4Done = 1;
            int House5Done = 1;
            int House6Done = 1;
            int questCompleation = 0;

            //the acutal game
            while (life > 0)
            {
                if (room == "throne")
                {
                    Console.WriteLine("*You enter a large throne room thats beautifuly funished and lavivishdly covered with gold with a Large intimidating man on the throne and a pesant standing next him*");

                    if (throneDone == 2)
                    {
                        Console.WriteLine("King: what are you doing here " + userName + " ? get back to your quest ");
                        Console.WriteLine("*the kings pesant ushers you out");
                        room = "Ccoridor";
                        throneDone = 2;
                    }

                    if (throneDone == 1)
                    {


                        //kings opnening 
                        Console.WriteLine(" king: Hellow " + userName + " look I have sumonded you to clear these streats becase literly every one is a crimnal so I am just going build a new city but first get rid of the people here");
                        Console.WriteLine(" and although I do know you are good would you like a new set of gear: * 1= no or 2= yes *");

                        //dicides what armour you have
                        AW = Console.ReadLine();
                        Console.WriteLine();

                        //kings responce
                        if (AW == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine("king: ok then, Cergey give him the armour");
                            Console.WriteLine();
                            Console.WriteLine("*A pesent handed you the gear*");
                            AC = 20;
                        }
                        else
                        {
                            Console.WriteLine("King: so be it");
                        }

                        Console.WriteLine("King: now go out and start your quest, and come back to me when you took down all the villans");


                        Console.WriteLine();

                        throneDone = 2;
                        room = "Ccoridor";

                    }

                    if (throneDone == 3)
                    {
                        Console.WriteLine("KING: so now that you have done your job I must congraglate you but at the same time...");
                        Console.WriteLine("KING: I CANT HAVE YOU TELLING PEOPLE WHAT I DID HERE SO I'LL JUST HAVE TO KILL YOU, cergey give me my wepons");
                        Console.WriteLine("*comabt starts*");
                        combat = true;
                        EnemyHP1 = 400;

                        while (combat != false)
                        {

                            Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                            AW = Console.ReadLine();
                            if (AW == "1")
                            {
                                EnemyHP1 -= AC;

                            }
                            if (AW == "2")
                            {
                                life += AC;
                            }
                            if (AW == "3")
                            {


                                EnemyHP1 -= AC / 2;
                            }
                            if (EnemyHP1 >= 0)
                            {
                                life -= 25;
                            }



                            Console.WriteLine(" KING'S HP=" + EnemyHP1);

                            Console.WriteLine(" your HP=" + life);
                            if (life <= 0)
                            {
                                combat = false;
                            }
                            if (EnemyHP1 <= 0)
                            {


                                combat = false;
                                AC += 10;
                                Console.WriteLine("*power is now " + AC + "*");
                                Console.WriteLine("*you leave the room after hiding the body's*");
                                room = "win";
                                Console.WriteLine();

                            }
                        }

                        questCompleation++;

                        Console.WriteLine("*comabat ends*");
                        life = 0;
                    }



                    Console.WriteLine("*You leave the throne room*");

                }
                if (room == "Ccoridor")
                {

                    Console.WriteLine("*as you enter the castle coridor it is filled with lavish decore and plated with more gold than most people ever see adn three doors * 1 to leave the castle , 2 to explore the rest of the castle , 3 to go back in the throne room");

                    AW = Console.ReadLine();

                    if (AW == "1")
                    {
                        room = "Cfront";
                    }

                    if (AW == "2")
                    {
                        room = "Ctreasure";
                    }

                    if (AW == "3")
                    {
                        room = "throne";
                    }

                }
                if (room == "Ctreasure")
                {

                    Console.WriteLine("*While you look around the area you see a couple doors that are all locked but a their is a pile of gold");

                    if (CtreasureDone == 1)
                    {

                        Console.Write(" gaurded by 2 fully armoured people*");
                        Console.WriteLine(" What do you do? 1= leave 2= initiate combat with guards 3= try and trick the gaurds");
                        AW = Console.ReadLine();

                        if (AW == "1")
                        {
                            Console.WriteLine("*you leave the area*");
                            room = "Ccoridor";
                        }
                        else
                        {

                            Console.WriteLine("Guards: What do you think your pullin");
                            Console.WriteLine("*combat starts*");
                            combat = true;
                            EnemyHP1 = 25;
                            EnemyHP2 = 25;

                            while (combat != false)
                            {
                                if (life > 200)
                                {
                                    life = 200;
                                }

                                Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                                AW = Console.ReadLine();
                                if (AW == "1")
                                {
                                    if (EnemyHP1 <= 0)
                                    {
                                        EnemyHP2 -= AC;
                                    }
                                    else
                                    {
                                        EnemyHP1 -= AC;
                                    }
                                }
                                if (AW == "2")
                                {
                                    life += AC;
                                }
                                if (AW == "3")
                                {

                                    EnemyHP2 -= AC / 2;
                                    EnemyHP1 -= AC / 2;
                                }
                                if (EnemyHP1 >= 0)
                                {
                                    life -= 9;
                                }
                                if (EnemyHP2 >= 0)
                                {
                                    life -= 11;
                                }


                                Console.WriteLine(" guard 1's HP=" + EnemyHP1);
                                Console.WriteLine(" guard 2's HP=" + EnemyHP2);
                                Console.WriteLine(" your HP=" + life);
                                if (life < 1)
                                {
                                    combat = false;
                                }
                                if (EnemyHP1 < 1)
                                {
                                    if (EnemyHP2 < 1)
                                    {
                                        combat = false;
                                        CtreasureDone = 2;
                                        AC += 2;
                                        Console.WriteLine("*power is now " + AC + "*");
                                        Console.WriteLine("*you leave the room after hiding the body's*");
                                        Console.WriteLine();
                                    }
                                }
                            }


                        }

                    }
                    if (CtreasureDone == 2)
                    {

                        Console.Write("wide open for the taking with a few blood spladers on the gold coins");
                        Console.WriteLine("*1= leave 2= take gold*");
                        AW = Console.ReadLine();
                        if (AW == "2")
                        {
                            money += 19;
                            Console.WriteLine("*you stole some gold and now have " + money);
                            Console.WriteLine("*after that you leave the treasure room*");
                            room = "Ccoridor";
                        }
                        else
                        {
                            Console.WriteLine("*you leave the treasure room*");
                            room = "Ccoridor";
                        }
                    }
                }
                if (room == "Cfront")
                {
                    Console.WriteLine("*as you walk out side you see that the sun is shining the birds are singing and beond that a large town with a couple houses and a lot of people*");
                    if (CfrontDone == "1")
                    {
                        Console.WriteLine("*1= look at buildings 2= go back into the castle*");
                        AW = Console.ReadLine();
                        if (AW == "2") 
                                {
                                    Console.WriteLine("*you go into the castle*");
                                    room = "Ccoridor";
                                }
                        if (AW == "1")
                        {
                            Console.WriteLine();

                            Console.WriteLine("*some buildings are | 1= a common brick house | 2= a wooden house with wooden moose shown in the windows | 3= a brick house with a lot of apple trees in its yard | 4= a big with quarts pillar bank that has a emrald lining | 5= a old brocken down shack that reaks of poison | 6= a realy big dog house with lots of purple and red splotches *");
                            AW = Console.ReadLine();

                            if (AW == "1")
                            {
                                room = "House1";
                                Console.WriteLine();
                                Console.WriteLine("*as you aproch the house you see that nothing much is in there but as you go into it there is a ");


                            }
                            if (AW == "2")
                            {
                                room = "House2";
                            }
                            if (AW == "3")
                            {
                                room = "House3";
                            }
                            if (AW == "4")
                            {
                                room = "House4";
                            }
                            if (AW == "5")
                            {
                                room = "House5";
                            }
                            if (AW == "6")
                            {
                                room = "House6";
                            }

                        }



                    }

                }
                if (room == "House1") { 

                if (House1Done == 1)
                        {

                            Console.WriteLine();
                            Console.Write(" exosted man sitting down with a cyckle next to some farming gear. *1= talk to the man 2= inspect the house 3= leave*");
                            Console.WriteLine();
                            AW = Console.ReadLine();
                            if (AW == "1")
                            {
                                Console.WriteLine("as you open your mouth to ask a question the man interrupts you and says 'WHAT DO YOU WANT?' ");
                                Console.WriteLine("1= are you a crimnal 2= whats your name 3= leave ");

                                AW = Console.ReadLine();
                                if (AW == "2")
                                {
                                    Console.WriteLine("Philps: I'm philps nice to meat you");
                                }
                                if (AW == "1")
                                {
                                    Console.WriteLine("*Philps: What are you talking about ?! you know what just leave*");
                                    Console.WriteLine("*1= leave 2= push for a anwser*");
                                    AW = Console.ReadLine();


                                    if (AW == "2")
                                    {
                                        combat = true;
                                        Console.WriteLine();
                                        Console.WriteLine("Philps: fine I'l just make you leave!");
                                        Console.WriteLine("*comabt starts*");
                                        EnemyHP1 = 55;

                                        while (combat != false)
                                        {

                                            Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                                            AW = Console.ReadLine();
                                            if (AW == "1")
                                            {
                                                EnemyHP1 -= AC;

                                            }
                                            if (AW == "2")
                                            {
                                                life += AC;
                                            }
                                            if (AW == "3")
                                            {


                                                EnemyHP1 -= AC / 2;
                                            }
                                            if (EnemyHP1 >= 0)
                                            {
                                                life -= 13;
                                            }



                                            Console.WriteLine(" Philps HP=" + EnemyHP1);

                                            Console.WriteLine(" your HP=" + life);
                                            if (life <= 0)
                                            {
                                                combat = false;
                                            }
                                            if (EnemyHP1 <= 0)
                                            {


                                            combat = false;
                                                AC += 2;
                                                Console.WriteLine("*power is now " + AC + "*");
                                                Console.WriteLine("*you leave the room after hiding the body's*");
                                                House1Done = 2;
                                                room = "Cfront";
                                                Console.WriteLine();

                                            }
                                        }

                                    questCompleation++;

                                        Console.WriteLine("*comabat ends*");
                                    }
                                    if (AW == "1")
                                {
                                    Console.WriteLine("*you leave*");
                                    room = "Cfront";
                                }

                                }
                                if (AW == "3")
                                {
                                Console.WriteLine("*you leave*");
                                room = "Cfront";
                                }


                            }
                            if (AW == "2")
                            {
                                Console.WriteLine("*you find 2 items witch one do you touch? press 1 or 2*");
                                AW = Console.ReadLine();
                                if (AW == "1")
                                {
                                    Console.WriteLine("*you find some gold*");
                                    money += 11;
                                    Console.WriteLine("* your gold is now" + money + "*");
                                    room = "Cfront";
                                }
                                else
                                {
                                    Console.WriteLine("what you picked up was boiling and you took 5 dammage");
                                    life -= 5;
                                    Console.WriteLine("* your hp is now" + life + "*");
                                    room = "Cfront";
                                }
                            }
                            if (AW == "3")
                            {
                                room = "Cfront";
                            }



                        }
                if (House1Done == 2)
                {
                    Console.Write("dead body on the floor barly hiddin*");

                    Console.WriteLine("*1= leave 2= inspect the house for items*");
                        AW = Console.ReadLine();

                    if (AW == "2")
                    {
                        Console.WriteLine("*you find 2 items witch one do you touch? press 1 or 2*");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        {
                            Console.WriteLine("*you find some gold*");
                            money += 11;
                            Console.WriteLine("* your gold is now " + money + "*");
                            room = "Cfront";
                        }
                        else
                        {
                            Console.WriteLine("what you picked up was boiling and you took 5 dammage");
                            life -= 5;
                            Console.WriteLine("* your hp is now " + life + "*");
                            room = "Cfront";
                        }
                    }

                }
                
                    }
                if (room == "House2")
                {
                    if (House2Done == 1)
                    { 
                    
                    Console.WriteLine("*as you aprotch the house you see not to much but you do hear a lot of moose and 2 people shushing and when you actuly go inside you see at least 50 moose and two people trying to fit them into boxes");
                    Console.WriteLine("The 2 people look at you and say :");
                    Console.WriteLine("guy 1:  oh noweve bean made smugling these moose!");
                    Console.WriteLine("guy 2:  he's sean to much get him");
                    Console.WriteLine("guy 1:  yah lets take him down");
                    Console.WriteLine();
                    Console.WriteLine("*combat starts*");
                        combat = true;
                    EnemyHP1 = 66;
                    EnemyHP2 = 44;

                    while (combat != false)
                    {

                        Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        {
                            if (EnemyHP1 <= 0)
                            {
                                EnemyHP2 -= AC;
                            }
                            else
                            {
                                EnemyHP1 -= AC;
                            }
                        }
                        if (AW == "2")
                        {
                            life += AC;
                        }
                        if (AW == "3")
                        {

                            EnemyHP2 -= AC / 2;
                            EnemyHP1 -= AC / 2;
                        }
                        if (EnemyHP1 >= 0)
                        {
                            life -= 9;
                        }
                        if (EnemyHP2 >= 0)
                        {
                            life -= 11;
                        }


                        Console.WriteLine(" guard 1's HP=" + EnemyHP1);
                        Console.WriteLine(" guard 2's HP=" + EnemyHP2);
                        Console.WriteLine(" your HP=" + life);
                        if (life < 1)
                        {
                            combat = false;
                        }
                        if (EnemyHP1 < 1)
                        {
                            if (EnemyHP2 < 1)
                            {
                                combat = false;
                                House2Done = 2;
                                AC += 7;
                                Console.WriteLine("*power is now " + AC + "*");
                                Console.WriteLine("*you leave the room after hiding the body's*");
                                    room = Cfront;
                                Console.WriteLine();

                                }
                            }
                        }
                        questCompleation++;
                    }
                    
                    if (House2Done == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*as you aprotch the small wooden house you do not see much but when you enter it you see a lot of moos and 2 dead bodys.*");
                        Console.WriteLine("*1= eat moose 2= leave*");
                        AW = Console.ReadLine();
                        if (AW == "2")
                        {
                            room = "Cfront";
                        }
                        if (AW == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("*you at all the moose and you are some how both proud and weirded out by yourself*");
                            Console.WriteLine("*your hp is not 150*");
                            life = 150;
                            House2Done = 3;
                            room = Cfront;
                        }
                    }
                    if (House2Done == 3)
                    {
                        Console.WriteLine("*as you walk to the small wodden house you dont see any thing unishual but when you go inside you see 2 dead bodys and moose bones*");
                        Console.WriteLine("*1= leave*");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        {
                            Console.WriteLine("*you leave the house*");
                            room = "Cfront";

                        }
                    }
                }
                if (room == "House3")
                {
                    if (House3Done == 1)
                    {

                   
                    Console.WriteLine("*as you start to walk twords the house surounded by apple treas a man jumps out of one and pulls you inside*");
                        Console.WriteLine("WEIRD MAN: I KnOw WHy YOur HerE , to take my apples and i wont let you so you can etheir fight (press 1) or i can bribe you (press 2)");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        { 

                            combat = true;
                            Console.WriteLine();
                             Console.WriteLine("WEIRD MAN: fine but your going down");
                            Console.WriteLine("*comabt starts*");
                            EnemyHP1 = 80;

                            while (combat != false)
                            {
                                if (life > 200)
                                {
                                    life = 200;
                                }

                                Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                                AW = Console.ReadLine();
                                if (AW == "1")
                                {
                                    EnemyHP1 -= AC;

                                }
                                if (AW == "2")
                                {
                                    life += AC;
                                }
                                if (AW == "3")
                                {


                                    EnemyHP1 -= AC / 2;
                                }
                                if (EnemyHP1 <= 0)
                                {
                                    life -= 4;
                                }



                                Console.WriteLine(" Philps HP=" + EnemyHP1);

                                Console.WriteLine(" your HP=" + life);
                                if (life <= 0)
                                {
                                    combat = false;
                                }
                                if (EnemyHP1 <= 0)
                                {


                                    combat = false;
                                    House3Done = 2;
                                    AC += 2;
                                    Console.WriteLine("*power is now " + AC + "*");
                                    Console.WriteLine("*you leave the room after hiding the body's*");
                                    House1Done = 2;
                                    room = "Cfront";
                                    Console.WriteLine();

                                }
                            }
                            Console.WriteLine("*comabat ends*");
                            questCompleation += 1;


                        }
                        if (AW == "2")
                        {
                            Console.WriteLine("WERID MAN: wooh becase i was not prepared to fight, here's some raw power");
                            AC += 4;
                            Console.WriteLine("*your power is now " + AC + "*");
                            House3Done = 3;
                            questCompleation++;
                        }
                    }
                    if (House3Done == 2)
                    {
                        Console.WriteLine("*there nothing here any more so you leave*");
                        room = "Cfront";                    }
                    if (House3Done == 3)
                    {
                        Console.WriteLine("WEIRD MAN: oh hey i sstarted a shoop 12 gold a healthy apple");
                        AW = "1";
                        while (AW != "2")
                        {

                            Console.WriteLine("*1= exept the deal 2= leave");
                            AW = Console.ReadLine();
                            if (AW == "1")
                            {
                                if (money >= 12)
                                {
                                    money -= 12;
                                    life += 20;
                                    Console.WriteLine("*your HP is now" + life + "*");
                                    Console.WriteLine("*your amount of gold is now " + money + "*");
                                }
                            }

                            if (AW == "2")
                            {
                                Console.WriteLine("*you leave*");
                                room = Cfront;
                            }

                            if (life > 200)
                            {
                                life = 200;
                            }

                        }
                         
                    }
                    room = "Cfront";
                }
                if (room == "House4")
                {
                    Console.WriteLine();

                    if (House4Done == 1)
                    {
                        Console.WriteLine("*as you look at the bank you see a couple shdie tax colecters talking and when you walk inside you see a arey of marble stachues and when you get insid eyou see one man standing allone taking all the money from the empty counter*");
                        Console.WriteLine("*the man looks at you*");
                        Console.WriteLine("THEIF 1: so are you going to walk away (press 1) or are you going to try and stop me (press 2)");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        {
                            Console.WriteLine("*you nevously leave the room*");
                            room = "Cfront";
                        }
                        else if (AW == "2")
                        {
                            combat = true;
                            Console.WriteLine();
                            Console.WriteLine("THEIF 1: ok , then your going down");
                            Console.WriteLine("*comabt starts*");
                            EnemyHP1 = 55;

                            while (combat != false)
                            {

                                Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                                AW = Console.ReadLine();
                                if (AW == "1")
                                {
                                    EnemyHP1 -= AC;

                                }
                                if (AW == "2")
                                {
                                    life += AC;
                                }
                                if (AW == "3")
                                {


                                    EnemyHP1 -= AC / 2;
                                }
                                if (EnemyHP1 >= 0)
                                {
                                    life -= 13;
                                }



                                Console.WriteLine(" THEIFS HP=" + EnemyHP1);

                                Console.WriteLine(" your HP=" + life);
                                if (life <= 0)
                                {
                                    combat = false;
                                }
                                if (EnemyHP1 <= 0)
                                {


                                    combat = false;
                                    CtreasureDone = 2;
                                    AC += 2;
                                    Console.WriteLine("*power is now " + AC + "*");
                                    Console.WriteLine();

                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine("*as you start to walk out you see the 2 tax colecters standing outside come in and say*");
                            Console.WriteLine("Tax Colecter 1: so it looks like you killed one of our men so i ges we will just have to kill you");
                            Console.WriteLine("*combat starts*");
                            combat = true;
                            EnemyHP1 = 37;
                            EnemyHP2 = 42;

                            while (combat != false)
                            {
                                if (life > 200)
                                {
                                    life = 200;
                                }

                                Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                                AW = Console.ReadLine();
                                if (AW == "1")
                                {
                                    if (EnemyHP1 <= 0)
                                    {
                                        EnemyHP2 -= AC;
                                    }
                                    else
                                    {
                                        EnemyHP1 -= AC;
                                    }
                                }
                                if (AW == "2")
                                {
                                    life += AC;
                                }
                                if (AW == "3")
                                {

                                    EnemyHP2 -= AC / 2;
                                    EnemyHP1 -= AC / 2;
                                }
                                if (EnemyHP1 >= 0)
                                {
                                    life -= 10;
                                }
                                if (EnemyHP2 >= 0)
                                {
                                    life -= 12;
                                }


                                Console.WriteLine(" tax colecter's 1's HP=" + EnemyHP1);
                                Console.WriteLine(" tax colecter's 2's HP=" + EnemyHP2);
                                Console.WriteLine(" your HP=" + life);
                                if (life < 1)
                                {
                                    combat = false;
                                }
                                if (EnemyHP1 < 1)
                                {
                                    if (EnemyHP2 < 1)
                                    {
                                        combat = false;
                                        CtreasureDone = 2;
                                        AC += 3;
                                        Console.WriteLine("*power is now " + AC + "*");
                                        Console.WriteLine("*you leave the room after hiding the body's*");
                                        Console.WriteLine();
                                        room = Cfront;
                                        
                                    }
                                }
                            }
                            House4Done = 2;
                            questCompleation += 1;


                        }
                    }
                    if (House4Done == 2)
                    {
                        Console.WriteLine("*as you enter the room you see 3 dead bodys on the floor and some cash on the floor");
                        Console.WriteLine("*1= leave 2= pick up the gold");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        {
                            Console.WriteLine("*you leave*");
                            room = Cfront;
                        }
                        else
                        {
                            money += 42;
                            Console.WriteLine("*you pick up the money and your gold is now " + money + "*");
                            House4Done++;
                        }
                    }
                    if (House4Done == 3)
                    {
                        Console.WriteLine("*there is nothing to do here so you leave*");
                        room = "Cfront";
                    }
                   
                }
                if (room == "House5")
                {
                    if (House5Done == 2)
                    {
                        Console.WriteLine("*there isn't a house there any more*");
                        room = "Cfront";
                    }
                    if (House5Done == 1)
                    {

                        Console.WriteLine("*as you start to aprotch the house you smell a hourid oddor but then | BAM! | a giant exploshion happens and a witch comes flying at the and says*");
                        Console.WriteLine("WITCH: ney hey hey i know what your doing and iey will puut a stoop to it");
                        Console.WriteLine("*comabt starts*");
                        combat = true;
                        EnemyHP1 = 26;

                        while (combat != false)
                        {

                            Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                            AW = Console.ReadLine();
                            if (AW == "1")
                            {
                                EnemyHP1 -= AC;

                            }
                            if (AW == "2")
                            {
                                life += AC;
                            }
                            if (AW == "3")
                            {

                                Console.WriteLine("WITCH: that does not work on me");
                                
                            }
                            if (EnemyHP1 >= 0)
                            {
                                life -= 30;
                            }



                            Console.WriteLine(" Witches HP=" + EnemyHP1);

                            Console.WriteLine(" your HP=" + life);
                            if (life <= 0)
                            {
                                combat = false;
                            }
                            if (EnemyHP1 <= 0)
                            {


                                combat = false;
                                AC += 2;
                                Console.WriteLine("*power is now " + AC + "*");
                                Console.WriteLine("*you leave the room after hiding the body's*");
                                House5Done = 2;
                                room = "Cfront";
                                Console.WriteLine();

                            }
                        }

                        questCompleation += 1;

                        Console.WriteLine("*comabat ends*");


                        room = "Cfront";


                    }
                    
                }
                if (room == "House6")
                {
                    if (House6Done == 1)
                    {
                        Console.WriteLine("*as you aprouch the gaint dog house you see a humunges puppy that starts to run twordes you witch a bone in its mouth*");
                        Console.WriteLine("*1= play with the dog 2= fight the dog*");
                        AW = Console.ReadLine();
                        if (AW == "1")
                        {
                            Console.WriteLine("*the puppy looks at you eagerly, runs into you then runs away");
                            Console.WriteLine("*you take 10 damage*");
                            life -= 10;
                            room = "Cfront";
                            
                                
                        }
                        if (AW == "2")
                        {
                            combat = true;
                            Console.WriteLine();
                            Console.WriteLine("*the dog looks hurt");
                            Console.WriteLine("*comabt starts*");
                            EnemyHP1 = 155;

                            while (combat != false)
                            {

                                Console.WriteLine("*1= mele attack 2= rest 3= magic*");
                                AW = Console.ReadLine();
                                if (AW == "1")
                                {
                                    EnemyHP1 -= AC;

                                }
                                if (AW == "2")
                                {
                                    life += AC;
                                }
                                if (AW == "3")
                                {


                                    EnemyHP1 -= AC / 2;
                                }
                                if (EnemyHP1 >= 0)
                                {
                                    life -= 6;
                                }



                                Console.WriteLine(" the PUPPY'S HP=" + EnemyHP1);

                                Console.WriteLine(" your HP=" + life);
                                if (life <= 0)
                                {
                                    combat = false;
                                }
                                if (EnemyHP1 <= 0)
                                {


                                    combat = false;
                                    AC += 2;
                                    Console.WriteLine("*power is now " + AC + "*");
                                    Console.WriteLine("*you leave the room after the dog runs away*");
                                    House6Done = 2;
                                    room = "Cfront";
                                    Console.WriteLine();

                                }
                            }

                            questCompleation += 1;

                            Console.WriteLine("*comabat ends*");
                        }
                    }
                    if (House6Done == 2)
                    {
                        Console.WriteLine("*you leave becase uhh you just leave*");
                    }
                }
                   


                if (life > 200)
                {
                    life = 200;
                }
                if (questCompleation > 4)
                {
                    if (throneDone != 3)
                    {
                        Console.WriteLine("*your quest is compleat go back to the king*");
                        throneDone = 3;
                    }
                    
                }
            }

    if (room != "win")
    {
    Console.WriteLine("You Lose");
    }
    else
    {
     Console.WriteLine();
     Console.WriteLine("*GOOD JOB YOU WIN*");
    }
           
        }
        
    }




}

