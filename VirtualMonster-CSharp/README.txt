Virtual Pet
Create a virtual pet. Maybe we can make this a fad!

Setup
 Go to GitHub Classroom and accept the Virtual Pet assignment by clicking on the green 'Accept this assignment' button.
 Follow the link to your repository and then click on the green 'Clone or download' button. Copy the URL onto your computer's clipboard.
 Launch IntelliJ and go to File -> New -> Project From Version Control and paste the above URL into the URL field. Make sure the directory is where you want the project to be on your computer.
 Change the README.md file in your project folder to describe what you've done with your project. No fancy formatting is necessary. Just separate paragraphs with an empty line. (If you'd like to learn more about Markdown formatting, check out the Github Markdown Guide.)
Classes
 You will need to create a VirtualPet class.
 VirtualPetApplication will house the main method. This is the starting point when the application runs.
 Stretch goal Build out unit tests in the VirtualPetTest class to test the behaviors placed in VirtualPet

Details
Create a virtual pet application. This is your version of a Tamagotchi or DigiPet! This might seem like a daunting task, but we can break it down.
Think of which instance variables and methods you will need. We give suggestions below. Remember that instance variables represent the state of your pet. Methods represent the behavior of your pet, which would include its responses to you feeding or playing with it.
Most games include what is called a game loop, a loop which updates everything in the game, representing the passage of time. We exit this loop when something happens that should cause the game to end. Include a tick() method (think clocks, not parasites) in your VirtualPet class representing the passage of a unit of time. This should do things like update instance variables of VirtualPet that are time dependent, such as hunger or thirst. You should call the tick() to represent the passage of time after each interaction with the user.
There is always some confusion with this tick() method. It has some flexibility, what you are doing is changing the properties of your Virtual Pet at some rate in this method...every time this method is called, those properties specified in this method would update.

Ideas
Attributes (instance variables) that a virtual pet might have, along with some ideas for activities (methods) that might address them are:

hunger (feed it)
thirst (water it)
waste (let it out to the bathroom)
boredom (play with it)
sickness (take it to the doctor)
Your methods should cause the appropriate instance variables to update - for instance, if you have a feed() method, it might make hunger go down, but make thirst go up.

Attributes that might update when tick() is called:

boredom increasing
hunger increasing
sleepiness increasing
If you play with the pet, perhaps that makes it more tired. Have fun with this part! Tip: You can use your README.md file to keep a list of features you'd like to incorporate.
Also, remember that more features != better. Pick a focus for your pet. Maybe go with a theme.
Your user interface should live in the main method of the VirtualPetApp class. Your VirtualPet class should not be writing messages to the console or reading user input. These are responsibilities of the VirtualPetApp class.
An example user interface is below (yours doesn't need to match this!):

Horace the Hippo
Hunger: 27
Thirst: 5
Boredom: 5
Tiredness: 50

What do you want to do?
1. Feed Horace
2. Water Horace
3. Play with Horace
4. Put Horace to sleep
5. Do nothing

> 1

You feed Horace.
Required Tasks
VirtualPet class

 Create a tick() method that represents the passage of time.
 Create at least three instance variables (aka attributes aka properties aka fields).
 Create at least three methods (messages you send to your pet).
VirtualPetApp class

Create a main method that…
 implements a game loop.
 asks for user input.
 writes output to the console.
Grading
Here is the rubric.

Stretch Tasks
 Give the pet the ability to take care of some of its own needs.

Pets are not robots - they usually have some sort of self-determination! When tick() is called, you might want to have your pet take a look at its needs and address one, prioritizing whichever need is highest. You could also make your pet uncooperative - when the user tries to feed the pet, for example, you might make the pet refuse to eat if it is bored.
Remember how we created an instance of the Random class to create a random number generator? You might want to incorporate that.
Create a visual representation of your pet.

Rather than using numbers to convey your pet's status, you could have some sort of visual representation of the pet. I.e., instead of printing hunger: 50, you could use smileys or ASCII art to show hunger when hunger >= 50.

     >=<        
,.--'  ''-.
(  )  ',_.'
Xx'xX      

Horace looks like this: :0

1. Feed Horace
2. Water Horace
3. Play with Horace
4. Put Horace to sleep
5. Do nothing
 Assign favorite foods to your pet, and add a parameter specifying the type of food to the method you use to feed your pet. Your pet should react accordingly. You could also decide which foods it does not like.

 Create Unit Tests!

Hints
Don't try to tackle everything at once! Break this project up into smaller chunks, and you will find that they are all manageable. (Getting comfortable testing as you go will make this project more manageable!!)

Virtual Pet Shelter
So, you have some experience under your belt in the care and feeding of a virtual pet. It's time to share that with the community! Time to volunteer!

Design a game that allows you to play the role of a pet shelter worker!

Setup
 Update the README.md file in your project folder to describe what you've done with your project. No fancy formatting is necessary. Just separate paragraphs with an empty line. (If you'd like to learn more about Markdown formatting, check out the Github Markdown Guide.)
Details
We're going to use TDD to drive the creation of an application that simulates you taking care of the pets in a shelter.

Include a game loop in this project, too. It should query the user, then call the appropriate method(s) on VirtualPetShelter and/or VirtualPet. In general, your VirtualPetApp should talk to your VirtualPetShelter, and your VirtualPetShelter should talk to your VirtualPet. Try to avoid VirtualPetApp talking directly to VirtualPet instances, apart from accessing basic information about pets (via get* methods).

Example Interactions
Thank you for volunteering at Big Al\'s Virtual Pet Shelter and Delicatessen!

This is the status of your pets:

Name	|Hunger	|Thirst	|Boredom
--------|-------|-------|-------
Joey	|83     |34     |23
Johnny	|69     |49     |2
Dee Dee	|39     |18     |88
Tommy	|59     |19     |37

What would you like to do next?

1. Feed the pets
2. Water the pets
3. Play with a pet
4. Adopt a pet
5. Admit a pet
6. Quit
Example Pet Selection Interaction
Ok, so you\'d like to play with a pet. Please choose one:

[Joey] looks like he\'s seen better days.
[Johnny] is a bit nervous.
[Dee Dee] probably didn\'t start with that many legs.
[Tommy] smells like a Stargazer lily fresh with morning dew.

Which pet would you like to play with?
Tommy

Ok, you play with Tommy.
Required Tasks to be completed in the order you feel is necessary
VirtualPetShelterApp class
Create a main method that…

 implements a game loop.
 asks for user input.
 writes output to the console.
 calls VirtualPetShelter's tick method after each interaction
Available user interface actions should include (at minimum)…

 feeding all the pets
 watering all the pets
 playing with an individual pet, which should display a list of pet names and descriptions, allowing a user to select one
 allow adoption of a pet, which should display a list of pet names and descriptions, allowing a user to select one. NOTE: In the past this has been a bit confusing. Keep in mind you are playing the role of a shelter worker, if a pet is adopted it will be removed from the shelter.
 allow intake of a pet, prompting the user for the pet's information, requiring the user to (at minimum) specify name and description
(Hint: you can use tab characters ("\t") to align console output in columns.)

VirtualPetShelter class
 include appropriate instance variable(s) to store the pets who reside at the shelter
 include methods that:
 return a Collection of all of the pets in the shelter
 return a specific VirtualPet given its name
 allow intake of a homeless pet (adding a pet to the shelter)
 allow adoption of a homeless pet (removing a pet from the shelter)
 feed all of the pets in the shelter
 water all of the pets in the shelter
 plays (or performs some other interaction(s)) with an individual pet in the shelter
 include a tick method that calls the tick method for each of the pets in the shelter, updating their needs
VirtualPet class
In addition to the requirements from last week's project:

 include instance variables representing:
 name (from the above example, this might be "Tommy")
 description (from the above example, this might be "smells like a Stargazer lily fresh with morning dew")
 include a constructor that accepts a name and description
 include a constructor that, in addition to name and description, accepts default values for the pet's attributes (hunger, boredom, etc)
 Do not include a default (zero arguments) constructor.
Grading
Your grading will be based on three areas:

Test Driven Development
Working Software
Clean Code
Test Driven Development
You should write your code by writing tests first. If you do so, each public method you write should have a unit test that covers its behavior. The test classes should also be well maintained and follow the principles of clean code. These are the things we are looking for with regards to Test Driven Development:

75% of your public methods (excepting the main() in your app class) should be covered by unit tests.
The principles of Clean Code as described below apply to your test classes.
All tests pass.
Working Software
Working software consists of does the application run and how well you met the requirements. Of the 30 required tasks above, we need to see 25 complete for this category to be considered PASSING.

Clean Code
Clean code deals with how your code is written. Is it readable, easy to understand, formatted, and not littered with commented out code? These are the things we will be looking for:

Keep method chains to a minimum. (Three chained methods in the entire project are permissable.)
Formatted code - This is the simplest task, use CTRL + ALT + L to have IntelliJ format your code for you.
Variable and Method Names - Variables and method names should inform the reader what the purpose of the variable or method is. A feed() method that affects the hunger field variable in your VirtualPet class is an example of good naming.
If you use descriptive method and variable names, your reliance on comments can be reduced. And you should never leave blocks of commented out code in your committed code.
We are looking for adherence to all four of the above principles for this category to be considered PASSING.

Stretch Tasks
 Consider any stretch tasks from last week's project that you did not attempt.
 Keep track of the cleanliness of individual pets' cages and offer an option in the user interface to clean pet cages
 DNA! In order to give your pets individual character, include as part of each pet's state one or more multipliers for needs so that one pet may become hungrier/thirstier/more bored slower/faster than another pet. (Tip: you could create a class to encapsulate this.)

Virtual Pets AMOK!
Oh noes! Your virtual pet shelter has become a mess!

Food and water and playtime aren't enough anymore. The virtual cats are chasing the virtual dogs. The virtual organic animals are letting nature take its course in every corner, while the virtual robotic pets are getting rusty. Let's just say things are piling up.

Thanks to the generosity of donors, leashes aren't an issue, so you can walk all of your virtual dogs at once. This is great, since they are less like to soil their cages if walked regularly. Did I mention dogs are in cages now? Yeah, it keeps the cats from chasing them. Better keep those cages clean.

We're introducing a health attribute for pets. Organic pets have their health decreased by unclean circumstances, and by thirst or hunger growing too high. Robotic pets only lose health if they're not oiled regularly. All pets lose health if their happiness drops too low.

Setup
 Go to GitHub Classroom and accept the Virtual Pet Shelter assignment by clicking on the green 'Accept this assignment' button.
 Follow the link to your repository and then click on the green 'Clone or download' button. Copy the URL onto your computer's clipboard.
 Launch IntelliJ and go to File -> New -> Project From Version Control and paste the above URL into the URL field. Make sure the directory is where you want the project to be on your computer.
 Create a README.md file in your project folder to describe what you've done with your project. No fancy formatting is necessary. Just separate paragraphs with an empty line. (If you'd like to learn more about Markdown formatting, check out the Github Markdown Guide.)
Required Tasks
General
introduce ways to track:
 cage cleanliness for organic dogs
 oil/maintenance level for robot animals
All classes
 Encapsulate all instance variables.
 Assign appropriate visibility modifiers to methods only used internally by a class or within a class hierarchy.
VirtualPet class and related subclasses/interfaces
In addition to the last project's requirements:

 create a model that allows for dogs and cats, either of which may be robotic
 introduce an attribute (instance variable) representing overall health that is updated as a result of other attributes moving in a negative or positive direction, influencing happiness
introduce methods that allow for:
 oiling robotic pets
 walking dogs, decreasing the likelihood that organic dogs will soil their cages, while increasing happiness in all dogs
do not allow:
 feeding/watering robotic pets
 oiling organic pets
 modify the tick method to return a value indicating the amount of waste a pet creates, which should contribute to either (optionally, create accessor methods to retrieve these values instead):
 amount of waste in an individual dog cage
VirtualPetShelter class
In addition to the last project's requirements:

introduce methods that allow for:
 oiling/maintaining all robotic pets
 cleaning dog cages
 modify existing methods to only feed/water pets that are not robotic
VirtualPetShelterApp class
In addition to the last project's requirements:

add options to:
 walk all dogs
 clean dog cages
 oil all robotic pets
Tips
Remember: don't get caught up in the user interface at first. Focus on shelter/pet behavior. Try to get one thing working at a time.
Create tests to verify pet behavior, limiting your immediate goal to something small.
Grading
Your grading will be based on three areas:

Object Oriented Programming Practices
Test Driven Development
Working Software
Clean Code You need a PASSING on three of the four areas for an overall passing grade.
Object Oriented Programming Practices
Show understanding of the 'A-PIE' principles of Object Oriented Programming:

Abstraction - Your abstractions should help make your code easier to work with. Think about separating high level concepts and low level concepts.
Polymorphism - Use method overriding to allow objects of a supertype to make method calls with different behaviors.
Inheritance - Use inheritance to keep concrete classes as simple as possible and remove duplicate code. Use abstract superclasses and interfaces to define properties and behaviors that all subclasses will inherit.
Encapsulation - Proper use of visibility modifiers to ensure that elements that should be private are kept private.
We need to see demonstration of 3 of the 4 principles for this category to be considered PASSING.

Test Driven Development
You should write your code by writing tests first. If you do so, each public method you write should have a unit test that covers its behavior. The test classes should also be well maintained and follow the principles of clean code. These are the things we are looking for with regards to Test Driven Development:

50% of your public methods (excepting the main() in your app class) should be covered by unit tests.
All tests pass.
We are looking for adherence to all of the above areas for this category to be considered PASSING.

Working Software
Working software consists of does the application run and how well you met the requirements. We are looking for your software to compile, a game loop to loop, and for 75% of the asked for requirements to be present to be considered PASSING.

Clean Code
Clean code deals with how your code is written. Is it readable, easy to understand, formatted, and not littered with commented out code? These are the things we will be looking for:

Keep method chains to a minimum. (Three chained methods in the entire project are permissable.)
Formatted code - This is the simplest task, use CTRL + ALT + L to have IntelliJ format your code for you.
Variable and Method Names - Variables and method names should inform the reader what the purpose of the variable or method is. A feed() method that affects the hunger field variable in your VirtualPet class is an example of good naming.
If you use descriptive method and variable names, your reliance on comments can be reduced. And you should never leave blocks of commented out code in your committed code.
We are looking for adherence to all four of the above principles for this category to be considered PASSING.

Stretch Tasks
Allow for other types of pets. Are they caged? What maintenance do they require?
Allow an option for giving treats to pets. What sorts of treats do different pets like?
introduce a Cage class for each dog, where cleanliness is tracked, keying these on the dog to which each is assigned (to use a VirtualPet as a key in a HashMap, you should implement hashCode and equals)
Cats hang out in a communal area and use a common litter box. Don't even bother trying to walk them. What happens if that litter box overflows? Does it reduce pets' health? Introduce a litterbox and a way to clean it for your organic cats.
Herd your cats.
(Note: the author is aware that it would not be a wise decision to allow all cats in a shelter to share a litterbox. They're virtual pets, so virtually disease-free.)