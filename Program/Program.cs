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
    Console.WriteLine("\nYou swing around the corner of the door to the dining room without making a noise\n you scan the room and spot a shadow, the same one you saw just moments ago\n");Thread. Sleep(2000);
    Console.WriteLine("you lunge forwards in pursuit of the shadow and it responds in kind by flittering along the wall to another doorway.\n");Thread. Sleep(2000);
}
else if(diningRoomOrReception == "main reception")
{
    Console.WriteLine("\nyou slide the door back to the main reception peering in, the room being lit by the light of the moon cascading down \neverything seems still, motionless and quiet but you notice something in the corner\n ");Thread. Sleep(2000);
    Console.WriteLine("A patch of wall darker than everything that surrounds it, you stare intently focusing on it.\n The darkness folds under your instense stare and begins to move.\n");Thread. Sleep(2000);
    Console.WriteLine("Now its moving you recognise it for the same shadow you saw moments ago. You charge after it leaping over furniture while it manevours to the nearest door.\n");Thread. Sleep(2000);
}
else if(diningRoomOrReception == "exit")
{
    return;
}

Console.WriteLine("\nBursting into a hallway you see the shadow dancing along the walls as it makes it way deeper within the manor.\n");Thread. Sleep(2000);
Console.WriteLine("As you run down the hallways you realise that this shadow is leading you further into the darkness.\n");Thread. Sleep(2000);
Console.WriteLine("While you runnning you conclude that there is only one villian this can be.\n");Thread. Sleep(2000);

Console.WriteLine("\nYou turn a corner halting abrubtly at the entrance to the kitchen. Inside you see a person tied to a chair doubled over with blood dripping from their face.\n");Thread. Sleep(2000);
Console.WriteLine("It's Alfred!\n");
Console.WriteLine("It's a trap you know as soon as you walk into that kitchen it will descend into a sufficating darkness.\n");Thread. Sleep(2000);
Console.WriteLine("If you can get to the back-up generator around the back of the houes you can turn the power back on and fight the darkness\n");Thread. Sleep(2000);

Console.WriteLine("\nDo you lunge forward to save Alfred or go to the Generator\n");Thread. Sleep(2000);

string alfredOrGenerator = Console.ReadLine();

if(alfredOrGenerator == "Alfred")
{
    Console.WriteLine("\nYou lunge forward, and complete darkness takes you, you surrounded by a swirl of shadows and blackness\n");Thread. Sleep(2000);
    Console.WriteLine("The last thing you hear before it all goes dark is Alfred\n");Thread. Sleep(2000);
    Console.WriteLine($"\"I'm Sorry master Bruce\"\n");Thread. Sleep(2000);

    return;
}
else if(alfredOrGenerator == "Generator")
{
    Console.WriteLine("\nYou exit the manor through a back door and quickly navigate the estensives grounds to the backup generator.\n");Thread. Sleep(2000);
    Console.WriteLine("Powering it on, you see the manor light up\n");Thread. Sleep(2000);
    Console.WriteLine("Sprinting back through the back entrance and then through the kithen door, you see the shadow and its darkness are gone.\n");Thread. Sleep(2000);
    Console.WriteLine("Only Alfred remains, you untie him and help him up.\n");Thread. Sleep(2000);
    Console.WriteLine($"Regaining his footing Alfred begins \"I'm sorry master Bruce, After our call ended I was engoulfed by darkness and woke up here, I'm not entirely sure how long its been\"\n");Thread. Sleep(2000);
    Console.WriteLine($"\"Don't apologise Alfred, it's Shade, I don't know how but he made it into the manor and past our security.\n");Thread. Sleep(2000);
}

Console.WriteLine("\nYou escort Alfred to the batcave entrence only to see the clock masking the secret door is now enclosed in a shadow.\n");Thread. Sleep(2000);
Console.WriteLine($"\"You can't leave that way Batman!\"\n");Thread. Sleep(2000);
Console.WriteLine("Spining on your heels you launch a handful of Baterangs in the direction of the voice and they disappear into the dark.\n");Thread. Sleep(2000);
Console.WriteLine("You turn back to the clock and see that the shadow has shrunk enough for you and alfred to squeez through to the batcave.\n");Thread. Sleep(2000);
Console.WriteLine("You carry ALfred down the steps to the bat computer, place him the chair infront of a dozen monitors and activate a failsafe\n");Thread. Sleep(2000);
Console.WriteLine("A hatch underneath the chair opens and the chair with Alfred in it begins to lower into a small armoured chamber.\n");Thread. Sleep(2000);
Console.WriteLine($"\"You'll be safe in there while I handle Shade\"\n");Thread. Sleep(2000);
Console.WriteLine($"As you turn your back you hear Alfred. \"Be Carefu..\"\n");Thread. Sleep(2000);


Console.WriteLine($"\nLooking around the batcave a voice erupted\"That was a mistake! You should have used that for yourself!\"\n");Thread. Sleep(2000);
Console.WriteLine("You look around trying to find the source of the voice but its impossible to pin down\n");Thread. Sleep(2000);
Console.WriteLine("Suddenly steps from behind annouce something moving towards you with speed \nYou pivot on your heels with your left arm in position for a devastating strike\n");Thread. Sleep(2000);
Console.WriteLine("Your fist connects with a shadow resembling a man\n");Thread. Sleep(2000);
Console.WriteLine($"\"You should have known better than to follow me back here\" moving towards the crumpled shadow on the ground\n");Thread. Sleep(2000);
Console.WriteLine("The shadow beings to resemble more of the man who weilds it. Shade stares back at you with his cold, dark hollow eyes.\n");Thread. Sleep(2000);
Console.WriteLine($"\"No matter I've accomplished what I set out to do, Bruce!\n");Thread. Sleep(2000);
Console.WriteLine("With that shade disolved into another shadow and then the batave flooded with light\n");Thread. Sleep(2000);
Console.WriteLine("all shadows chased out and Batman with a new case!\n");Thread. Sleep(2000);

return;
