using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

Console.WriteLine("\nWelcome to the begining of Batman: Mansion of Shadows.\n");
Console.WriteLine("You will play the part of our dark knight.\n");
Console.WriteLine("You will be faced with puzzles that will require great detective work.\n");
Console.WriteLine("Shall we begin?\n");

string decision = Console.ReadLine();

if (decision == "yes")
{       
    Console.WriteLine("\nthen let our story begin.");
}
else if (decision == "no")
{
    Console.WriteLine("\nThis is why everyone likes superman more.\n");
    return;
}
else if(decision == "exit")
{
    return;
}

Console.WriteLine("\nThe darkness that clouds Gotham is pirced by rays of light as morning approches.\n"); Thread. Sleep(2000); // Sleep for 4 seconds
Console.WriteLine("You've beaten another night that threatened to be your last.\n"); Thread. Sleep(2000);
Console.WriteLine("You're driving back to Wayne Manor when you notice a small light flickering on you dashboard.\n"); Thread. Sleep(2000);
Console.WriteLine("It's your communicator, Alfred is trying to contact you.\n"); Thread. Sleep(2000);
Console.WriteLine("Do you answer?"); Thread. Sleep(2000);

string answerCall = Console.ReadLine();

if (answerCall == "yes")
{
    Console.WriteLine($"\n\"Good morning sir. are you on your way home yet? you've been out there for \ntoo long this time, I'm surprised you can see stright.\"\n");Thread. Sleep(2000);
    Console.WriteLine($"\"Croc was causing trouble near Gotham general hospital tonight, seems that \nsomeone tipped him of with false information that they had something that \ncould help cure him.\"\n");Thread. Sleep(2000);
    Console.WriteLine($"\"He was not please when he realised he had been lied to.\"\n");Thread. Sleep(2000);
    Console.WriteLine($"\"No, I'd imagine he would not be. In any case master Bruce, hurry \nhome you need rest.\"\n");Thread. Sleep(2000);
    Console.WriteLine($"\"I've just passed the city limits, I'll be home soon.\"\n");Thread. Sleep(2000);
}
else if (answerCall == "no")
{
    Console.WriteLine("you stare at the light for a moment before is ceases its flickering, whatever it may be it can wait until you arrive home.\n");Thread. Sleep(2000);
}
else if(answerCall == "exit")
{
    return;
}
 
Console.WriteLine("press space to continue"); Console.ReadKey();

Console.WriteLine("\nYou drive along the secret entrance leading to the batcave, cloaked under a waterfall.\n");Thread. Sleep(2000);
Console.WriteLine("driving down a large ramp you stop in the center of the cave on a large cricular disk.\nJumping out of the Batmobile you walk across the room on what seems more like a \nconstruction site scaffholding that a walkway of a scret hideout.\n");Thread. Sleep(2000);
Console.WriteLine($"Sitting down at your central computer you begin to look at headings for that days news, \"batman thrwats Killer Croc and saves Gotham general!\"\n");Thread. Sleep(2000);

Console.WriteLine("press space to continue"); Console.ReadKey();
//Thread. Sleep(4000); // Sleep for 3 seconds.

Console.WriteLine("\nYou struggle to shake the feeling that last night was too quiet, yes you had to fight \ncroc but nothing else seems to have happened in that time.\n");Thread. Sleep(2000);
Console.WriteLine("you lose yourself in thought before realising that Alfred has arrived yet. He typically \narrives moments after you but this time silence.\n");Thread. Sleep(2000);
Console.WriteLine("And now that you've notice his absence you being to notice that quiet that has infected \nthe cave, you can't even hear the bats that have made this cave their home nor the water that drips\n");Thread. Sleep(2000);
Console.WriteLine("you move towrds the elevator to the manor above but hear a noise to your right, it sounds like a dragging noise\n");Thread. Sleep(2000);

Console.WriteLine("Do you investigate the batcave or go to the manor?");Thread. Sleep(2000);

string investigateTheCave = Console.ReadLine();

if (investigateTheCave == "batcave")
{
    Console.WriteLine("\nYou move towards the noise, inching closer with a hand gripping a baterang from your belt\n");Thread. Sleep(2000);
    Console.WriteLine("You turn a corner and see that the noise is coming from behind a stack of boxes\n");Thread. Sleep(2000);
    Console.WriteLine("Do you dash around the boxes or jump over them?\n");Thread. Sleep(2000);

    string dashOrJump = Console.ReadLine();

    if (dashOrJump == "dash")
    {
        Console.WriteLine("\nYou dash around the corner and there is nothing there.\nYou inspect the area and see a shadow and for a second it feels like the shadow sees you.\n");Thread. Sleep(2000);
        Console.WriteLine("You whip round to get a better look and asess if the shadow is a threat but as soon as you turn fully its gone. There is now nothing there.\n");Thread. Sleep(2000);
    }
    else if (dashOrJump == "jump");
    {
        Console.WriteLine("\nYou launch yourself over the boxes with flawlessly your body performing a perfect summersault that you've done a thousand times.\n");Thread. Sleep(2000);
        Console.WriteLine("This time though you land inside a shadow, a darkness that completely envelops you before you have time to realise whats happened to you the shadow is gone.\n");Thread. Sleep(2000);
        Console.WriteLine("Before your very eyes the shadow that threatenet to completly sufficate you is gone.\n");Thread. Sleep(2000);
    }
    Console.WriteLine("\nWhatever it may have been you can see no trace of it now, and move for the elevator to the manor. you need to find Alfred!\n");Thread. Sleep(2000);
}
else if(investigateTheCave == "manor")
{
    Console.WriteLine("\nYou move towards the elevator, turning as you doors close you notice something \na shadow, but somethings wrong, this shadow looks at you, peering into your person.\n");Thread. Sleep(2000);
    Console.WriteLine("Before you have the chance to investigate the elevator doors close and you begin to climb towards the manor\n");Thread. Sleep(2000);
}
else if(investigateTheCave == "exit")
{
    return;
}

Console.WriteLine("press space to continue"); Console.ReadKey();

Console.WriteLine("\nexiting the elevator you move along the walls watching for anything out of the ordinary. \nYou focus your hearing, listening out for the faintest of sounds.\n");Thread. Sleep(2000);
Console.WriteLine("On your left there is the dining room and on your right there is the main reception.\n");Thread. Sleep(2000);
Console.WriteLine("Where do you go? dining room or main reception.\n");Thread. Sleep(2000);

string diningRoomOrReception = Console.ReadLine();

if(diningRoomOrReception == "dining room")
{
    Console.WriteLine("You swing around the corner of the door to the dining room without making a noise\n you scan the room and spot a shadow, the same one you saw just moments ago\n");
    Console.WriteLine("you lunge forwards in pursuit of the shadow and it responds in kind by flittering along the wall to another doorway.\n");
}
else if(diningRoomOrReception == "main reception")
{
    Console.WriteLine("you slide the door back to the main reception peering in, the room being lit by the light of the moon cascading down \neverything seems still, motionless and quiet but you notice something in the corner\n ");
    Console.WriteLine("A patch of wall darker than everything that surrounds it, you stare intently focusing on it.\n The darkness folds under your instense stare and begins to move.");
    Console.WriteLine("Now its moving you recognise it for the same shadow you saw moments ago. You charge after it leaping over furniture while it manevours to the nearest door.");
}
else if(diningRoomOrReception == "exit")
{
    return;
}


