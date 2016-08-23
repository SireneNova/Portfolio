/*Background: 
The game is a series of steps in a story that gives the player different choices. 
After each story message, a button appears to reveal options and continue. 
When the page is refreshed the button appears too early, before the text finishes, so
my team designed a forced time delay on the button that takes effect only when the page refreshes.
My team had been counting the seconds for each step manually and entering it in.
There are a lot of steps, so I attempted to make a function that would calculate 
the time delay automatically. The function worked, but the script could not use 
the calculated value because it could not be recognized as a global variable.
*/
	function intro(){
            $("#instructions").empty();
            $("#story").empty();
            $("#buttonYes").hide();
            $("#buttonOptions").hide();
						            
			instruct = "^500I awoke. Dizzied and surrounded by dark. My head was spinning and there was a </br>sharp pain in the upper right side of my skull.  What am I doing here? \"Where is here?\" </br>I thought. First things first, orient myself. </br>I couldn't remember what had happened prior to my unconsciousness. I stood up and looked ahead. </br>There was a vague outline of a path that appeared to lead up to a house. I could barely make out an old mansion. </br>I looked behind myself and saw nothing but black. I heard what sounded like footsteps walking toward me from the rear.";
            
			//BP:
			messageDelay(instruct); //Defined at end of file
			alert(calc); //This alerts calc from above function, the time delay needed for a firstchoice button. It is based on the length of "instruct" message in this intro function.
						
			localStorage.setItem('instruction', instruct);
            addToInstructions(instruct, function() { firstchoice(); });

    }

//BP: Tested if calculation from previous function could be called from here, outside the source function:
//alert(window.calc); // does not register here 
//alert(calc);


//BP: Tested adding calculated variable in firstchoice:
//speedTest = window.calc;
//speedTest = 6000;
speedTest = 32536;
    function firstchoice() {
		
		buttonReset();
		
		//This paragraph ensures the time delay on a button is maintained after the page is refreshed:			
        if (localStorage.getItem('num') == '0') {
			revealOptions(firstchoice, speedTest); //BP - speedTest stands in for the time delay. Tested with some different variables, shown above this function. It only worked with numbers.
        } else{
            revealOptions(firstchoice);
        }
        localStorage.setItem('num', '0');

        addToInstructions("^1000<br>WHAT DID I DO?</br> Option 1: INVESTIGATE THE FOOTSTEPS</br>Option 2: WALK TOWARD THE HOUSE </br>  ");

        $(".yes3").one( "click", function(){
			$('#buttonReveal').hide();
            msg = "I turned around and walked away from the house. A large figure walked toward me on the path. In its hand I saw what appeared to be an ax. \"Hello?\" I ventured. No response, just a quickened pace. Its arm lifted the weapon high into the air. I turned to run but I was too late. The ax brutally removed my head from its shoulders and this is the end of my story.";
            deadanddead(msg, firstchoice);
        });

        $(".no3").one( "click", function(){
			$('#buttonReveal').hide();
			$('#buttonOptions').hide();

            instruct = "I made my way up to the house. It appeared to be old and in need of repairs. Regardless, it held a certain beauty.</br>There looked to be about four stories, each floor big enough to contain a large family. Something gleamed to my left on the path. I looked over and saw a hatchet."; 
            
			localStorage.setItem('instruction', instruct);
            addToInstructions( instruct, function(){
                firstfirstchoice();
            });
			
        });
		
		
    }
	
	
//BP
//Calculation of time delay for instruct nessages:
//speed is the message streaming speed and calc is the calculated delay needed. Both are in milliseconds per character.
var speed=52; //I calculated this speed manually. There is a typeSpeed parameter, but the units are uncertain.
	function messageDelay(message){
		_len = message.length;
		calc = (speed*_len)+3000; 
		window.calc = calc;
		return window.calc; // I thought window.calc would turn calc into a global variable, but it does not.
	}
	});
	
	
/*Background:
Even without the page being refreshed, I noticed there were areas of the script where the 
reveal button would show too early. I found that it was because the story text was placed in a 
different spot than usual, in a further down function. I made it into the "instruct=" messages,
in a further up function. Most of the options were designed this way. The messages are the same here 
because the outcome is the same for each option in this case. This fixed the delay error.
*/
	//BP: Added instruct messages here. Removed it from the beginning of sixthchoice options. It would interfere with the time delay on a button.
    function fifthfifthchoice() {
        buttonReset();

		revealOptions(fifthfifthchoice);

        addToInstructions("<br>WHAT DID I DO?<br>Option 1: HIDE UNDER THE TABLE<br>Option 2: HIDE IN THE CLOSET<br> ");
        $(".yes11").one("click",function(){
			$('#buttonReveal').hide();
			$('#buttonOptions').hide();
            localStorage.setItem('num', '8');
			instruct="I hid and a man entered the room. He had a white shirt on with red stains. He wore a torn sack on his head and carried a double barreled shotgun. I held my breath. Lucky for me the man quickly stepped through the kitchen. He knocked over some chairs and arrived at a staircase and a door. He chose the door and exited the room. I waited until I no longer heard him. \"I need a gun\" I thought."
            localStorage.setItem('instruction', instruct);
            addToInstructions( instruct, function(){
				sixthchoice();
            });
		});
        $(".no11").one("click",function() {
			$('#buttonReveal').hide();
			$('#buttonOptions').hide();
            localStorage.setItem('num', '8');
            instruct="I hid and a man entered the room. He had a white shirt on with red stains. He wore a torn sack on his head and carried a double barreled shotgun. I held my breath. Lucky for me the man quickly stepped through the kitchen. He knocked over some chairs and arrived at a staircase and a door. He chose the door and exited the room. I waited until I no longer heard him. \"I need a gun\" I thought."
            localStorage.setItem('instruction', instruct);
            addToInstructions( instruct, function(){
				sixthchoice();
            });
		});
        }
//BP: fixed delay bug
    function sixthchoice(){
        buttonReset();

		revealOptions(sixthchoice);

        addToInstructions("</br>WHAT DID I DO?</br>Option 1: GO UP THE STAIRS</br>Option 2: FOLLOW THE MAN WITH THE SHOTGUN</br> ");
        $(".yes12").one("click",function(){
			$('#buttonReveal').hide();
			$('#buttonOptions').hide();
            localStorage.setItem('num', '9');
            instruct = "I made my way up the staircase to what appeared to be the second floor of the house. There was a long hallway ahead of me. There was a table with a lit candle on it. I saw what looked to be a folder. There was a single sheet of lined paper on it. A scrawled quote was written, \"Most people do not really want freedom, because freedom involves responsibility, and most people are frightened of responsibility.\" -Sigmund Freud \"Well that\'\'s a load of crap\" I thought to myself. I paused and contemplated my current situation. I had a fleeting thought, \"Maybe I should just burn this house down...\"";
            localStorage.setItem('instruction', instruct);
            addToInstructions( instruct, function(){
                seventhchoice();
            });
        });
        $(".no12").one("click",function() {
			$('#buttonReveal').hide();
            msg="I opened the door. Despite my attempts to be quiet, it creaked loudly. I heard shouting and heavy footsteps. The man with the shotgun appeared and before I could defend myself, he blew my head off with a hail of bullets. And this is the end of my story.";
            deadanddead(msg,sixthchoice);
        });
    }
	
