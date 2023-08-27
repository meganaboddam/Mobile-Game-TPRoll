[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-c66648af7eb3fe8bc4f294546bfd86ef473780cde1dea487d3c4ff354943c9ae.svg)](https://classroom.github.com/online_ide?assignment_repo_id=8924295&assignment_repo_type=AssignmentRepo)
Hint: [Markup Guide](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)

# CheckPoint3 Task Checkout List
File created to keep track of MVP tasks, Overall description at below
## Add your name after your desired task;
### Add DONE infront of your finished task;
#### Add any features you can think of in the list, give it a priority tag infront (0 is MVP)
### Add LATER to finish task during next checkpoint

DONE [P1] Avatar display [Austin]

DONE [P1] Food varities [Austin] -with speed up and ememy generation

DONE [P2] Ememy movement scaling [Austin]

DONE [P1] Weapon paper roll [Austin]

DONE [P0] Social Media Page API [Megana]

LATER [P0] Social Media Permissions [Megana]

DONE [P0] App Link Creation & Send [Megana]

LATER [P0] Test Social Media Link [Megana]

DONE [P0] Option resize problem [Chris]

LATER [P0] Photo Premissions [Chris]

LATER [P0] Photo editing [Chris]

LATER [P0] Avatar replacement [Chris]

LATER [P0] Full screen Ad - every 3 gameplays [Austin]

LATER [P1] Starting Story Scene w/ or w/o tutorial [Austin]

DONE [P0] Tomestone design - State Managment [Austin]

LATER [P2] Localization/String translations

DONE [P1] No audio playing when in background [Unity]

DONE [P2] Landscape Orientation [Austin]

DONE [P1] Nightclub Option [Austin]

LATER [P2] Poo display animation [Austin]

LATER [P2] Roll direction arrows? [Austin]





# TP Roll
## Tagline: escape your 💩 
*Megana Reddy Boddam, Austin Yao, Chris Yu*
 
*Version #1*

## Summary of Project

The creator of Super Mario, Miyamoto, believes that the games people love to play are first, easy to play; second, tempting to make mistakes in; and third, make it easy to fall into traps. 

In our game, TP Roll, the user plays a forever hungry, forever in poop, little smiley emoji. The emoji's poop will become a poop monster to catch the emoji. The emoji will need to indulge in a big meal to gain speed to escape the poop monster, but at the same time, more poop monsters will spawn because of the emoji's indulgence in a big meal. Only the TP Roll icon saves the emoji because it wipes out some of the poop monsters. 

This game is very simple, as Miyamoto suggested. The user just needs to keep eating the food icons, and accumulate poop-emoji points. In the meanwhile, the higher the poop-emojis means there will be more poop monsters chasing the user. The running speed will become faster (the poop-emoji speed is always logarithmically increasing), which makes it easier for the user to make mistakes. 

The user's goal will be to get the maximum possible poop emoji score before a mistake is made and the smiley emoji dies. When the user thinks they've got a good score, they will be able to rhetorically throw their poops towards their friends and let them join the poop party. We plan to accomplish this through integrating social media APIs as described in more detail below.

## Project Analysis

### Target Audience

The App is currently targeting teenagers and young adults around the world that uses updated Android mobile phones. Young adults and teenagers are more likely to try out free games and have a higher chance to be influenced by peer sharing through social media. The game will mostly use recognizable icon images to decrease the language barrier. Only the default sharing message might need to adjust to localization needs.

### Monetization Model

- We plan to make this game free to download.
- To generate money, we plan to use advertisements.
  - There will be a full screen advertisement upon the death of the user in the game. It can be automatically exited out by the user to go to the next page of the game.
- We have not yet thoroughly discussed an app store schema. However, in the future, we have plans to make the avatar "smiley face" emoji editable. To access this feature, we would ask the user to pay in real money. Moreover, we could make a premium version of the game, accessible and payable through the app store, which allows the user the above feature and allows them to avoid advertisements.

### Primary Purpose

Primary purpose of this game is to provide simple, funny, and interesting gameplay. We hope to also strengthen the player’s interpersonal connections with their friends by encouraging users to challenge each other. This game also contributes to bettering society by encouraging the unconscious mental processing of junk food consumption as highly risky with negative consequences. This game will aim for a semi-dark but hilarious design to provide happiness and help destress the users. We hope it could end up being something that a user could play while in the bathroom for longer periods of time, potentially in the morning (*wink*). 

### Value Proposition

People need and want to destress. In 2021, researchers predicted acute medical stress to be prevalent in 29.6% of the world population (due to many factors and specifically, the pandemic) [1]. Quick game plays are one way to do so. At least 5 research articles in 2021 show evidence that people play virtual games purposefully for stress recovery [1]. People also are generally competitive with each other. We have a psychological need to sort each other out with some form of a hierarchy - most often, a numeric ranking. So, this game feeds into that need with its scorekeeping and facilitation of social bragging interactions [2].   

### Success Criteria

Financial gain:
- Advertisement: After our game accumulates some players, the ads will play an important role. We designed two styles of ad, the first one is the "valuable" ad, which will appear after the player lost a game and they could watch a 15-30 secs ad to gain a resurrection, which was decided whether to watch or not by the player. The second style will always show the bottom of the screen after players lost one game that only occupied 1/5 part of the screen which will not bother the player.

User satisfaction:
- Download number: This game's purpose is to let itself be “viral”, the download number is the most intuitive character of whether it is "viral" or not.
- Player rating of the game: User experience is clear only to the users themselves, and the user's rating of the game is the best reflection. Meanwhile, we can design a set of user feedback questionnaires in the game settings, which can let players with opinions provide suggestions to us directly. This method is more efficient compared to sending email feedback.
- Average gameplay time per user: A game that is willing to let players spend time on it is also considered successful, which involves game design, if the game is designed to be too simple may make players feel no challenge, too difficult will discourage players.
- Crash number: The number of crashes and their causes are important factors to help game makers improve their games, but at the same time a low percentage of crashes can represent the stability and robustness of the game design.
- Share count: A special feature of this game is you could "throw the poop to your friends" to arouse the players' desire to win.

### Competitor Analysis

*GAME #1: Flappy bird - One click- One-way movement - up*
Description: 
- It’s a low pixel 2D one-click balancing game. Each click on the phone screen counteracts gravity and keeps the Flappy bird flying. Players need to avoid the bird hitting the pipes spawning in the bird’s front from both the top and bottom sides. 

Strengths: 
- Easy to play, simple (low entry)
- Free (low entry, K9 students likely to try free games)
- Quick-Game plays (suits mobile/phone user needs)
- Availability (iOS and Android are both able to play)
- Sharable (increase number of reasons to play)
- Fair (no powerups, everyone has same experience)
- Familiar graphic choice (raise interest in familiar gamer base)
- Emphasis on the “Score” with “coin” Sound Effects (Mental reward and Raise challenges)
- Ads don’t break game experience (End game banner, hardly noticed)
most downloaded free game in iOS
- Earning $50,000 a day from in-app advertisements [3]
- Ridiculous difficulties (High skill ceiling, creates hardcore fanbase?)
- Addictive (Simple appearance and control with high difficult make user can’t believe failure) [4]

Weaknesses:
- Ridiculous difficulties (People will give up) [5]
- Download needed (entry price)
- No progression (Nothing changes in terms of gameplay)
- Not fun (even author took down the game)

*GAME #2: TEMPLE RUN* 
Description: 
- It is a 3D limitless running video game where the user explores an ancient ruin site by swiping left and right to obtain relics and points, while escaping virtual harmful creatures that chase the user.

Strengths:
- It is simple, easy, and addictive, which allows all ranges of age groups to enjoy it.
- No language skills were needed to understand the game. 
- It is available on many platforms like iOS, Android, PC, etc. 
- High user ratings on the various download platforms showed its legitimacy as a good game. 
- This app became very popular; there were more than 1 billion downloads [6]. 

Weaknesses:
- There is a feeling of intense competition because of the chasing monkeys and beating high scores of other users.
- The game concept is too easy to duplicate. Too many substitute games exist.
- Consumer tastes of games change continuously, so continuous improvement is required to keep the game fresh. 

*GAME #3: Snake game = 4 button - 4-way movement*
Description: 
- Snake is a classic game that requires players to assess their surroundings and find the quickest or safest route to a point. This is an excellent opportunity to learn about spatial awareness and plan ahead to your next move. The classic game is infamous for using your own success against you when you become so long that you get in your own way. 

Strengths:
- The game is very intuitive so players can get up and running very quickly.
- It was created at a very early time(1976) that PC just published several years ago, which makes this game phenomenal, almost everyone who used PC knows this game.
- Easy to share and easy to learn

Weakness:
- Single gameplay and scene, easy for players to produce visual and aesthetic fatigue.
- The game production is very simple, easy to be copied by other manufacturers, and even the players themselves can copy.
- The game lacks updates, making it difficult to catch the appetite of players.
- Single-player games make players almost no interactive fun, which makes snake games hard to monetize.

## Initial Design
The Minimum Viable Product is described below.
- We will have 6 total pages in the application.
  - The home page
  - The tutorial page
  - The game play page
  - The end game page 
  - The settings page
  - The social media interactions page
- The home page
  - Name and tagline of the game
  - The default avatar, which is a smiling face emoji
  - The highest score of the user
- The tutorial page will have a tutorial for how the avatar can move. This will not count towards the game or the score. 
- This tutorial page will also have some story scenes that set up the actual game.
- There are 4 game play movements. The avatar can move up, down, left, and right. On a touchscreen, swiping anywhere on the screen will allow the user to access these movements.
- The game play page
  - The map for the game play will be bigger than the mobile screen. However, it will be bounded.
  - The view of the map is locked on the avatar in the center of the screen.
  - The score for the game will be based on the number of poop emoji created by the avatar. This is achieved through moving towards ('eating') the following emojis.
  - 🍏 Green Apple
    - This only increases the speed of avatar
  - ☕ Coffee		
    - This increases the speed of the avatar and the number of poop emoji by 1.
  - 🍦 Soft Ice Cream	
    - This only increases the number of poop emoji by 3.
  - The poop emojis will become enemies of the avatar and attack the avatar.
  - The poop emoji enemies can be defeated by using the following emoji.
    - 🧻 Roll of Toilet Paper (TP Roll)
    - Half of the nearest poop emoji will be destroyed (will disappear) with magical sparkles once this emoji is collected by the avatar.
  - The difficulty of the game increases with the speed of the avatar (increases with apple and coffee), the speed of the poop emojis (constantly logarithmically increasing) and number of poop emojis moving towards the avatar.
  - The game ends when either the avatar runs into the poop-emojis or when the user chooses to end it. 
  - The user can choose to pause the game. 
  - The goal is for the avatar to try for endless survival in the gameplay environment.
- There will be only 1 life for the avatar. The game will restart (go back to the home page) with a score of 0 poop emojis if the user wants to play again. The user will have to click through a full screen banner advertisement to get to the homepage and play the game again. 
- The settings page has the buttons to end the game, restart a paused game, and to send the current score (# of poop emojis) to the user's friends.
- The social media page is accessed through the settings page. It allows for sharing this game with the user's friends.
  - Draft an editable message
    - It will have score of user "# poop". 
    - A challenge link that takes anyone who clicks it to the game or to download the game on the app store.
    - Potential Idea for a message: "'friend name', I pooped # times on you. Can you beat my 'poop emoji' -> deep link to game"
  - Ability to select social media connection
  - Ability to send post/story/direct-message on specific app
- The end game page should have the link to the social media page

### UI/UX Design

Our UI/UX design mockup is shown in the following Figma link:
https://www.figma.com/proto/UOy8umrF97Ns3MEuZNZ9ql/545-team-library?node-id=414%3A256&scaling=min-zoom&page-id=0%3A1&starting-point-node-id=449%3A310

- We use hierarchy and menu navigation methods to connect pages including Home, Game-Play, Settings, Pause and End-Game.

### Technical Architecture

Necessary components:
- Database: SQL databases will be used for storing data such as local user preferences, gameplay variables, etc. Some specific examples are below. The maximum storage file size will be 1 gigabyte.
  - User Data: 
    - Tutorial finished? 
    - Current Highest score 
    - Friends’ score (maybe in future)
  - Game Play Data 
    - Current score - poop emoji # 
    - Current speed 
    - Current living poop emoji on screen
Web/Cloud Interactions:
- Needed when users download this game.
- Needed when users want to share this game to their friends, then the game has to call social media APIs.
- Store data in a cloud database.
Success Measurement:
- crash rate: A very low crash rate means that the code is logical and the robustness of the program enhances the user experience, which is a very important factor for success.
- replay ability: Because the game can record the scores of friends, players can constantly update their best scores, thus allowing the game to fall into a cycle of challenges, capturing the user's psychology and greatly increasing the playability of the game.

Development tools:
- VS Code
- Unity 3.3 - 2D mobile
- C# 9.0
- MySQL Database

## Challenges and Open Questions

- None of the 3 team members have used C# before. Two of us have used Java extensively and one of us has used C++. We believe we will be able to learn C# easily enough to be able to program the above MVP.
- We must do more research on how our app can access social media apps through APIs. We understand that there are particular keys to utilize APIs but we need to learn more about the process of calling them with specific headers, urls, keys, message bodys, etc.
- Because our game is intended to be unlimited, we need to counteract the fact that our performance may decrease with the more emojis on the screen or the longer the user plays the game. 
- Considering different screen sizes will be a specific mobile app challenge. 

## References

1. https://www.ncbi.nlm.nih.gov/pmc/articles/PMC8675663/
2. https://www.scirp.org/journal/paperinformation.aspx?paperid=73535
3. https://www.theverge.com/2014/2/5/5383708/flappy-bird-revenue-50-k-per-day-dong-nguyen-interview
4. https://www.mauronewmedia.com/blog/why-flappy-bird-is-was-so-successful-and-popular-but-so-difficult-to-learn-a-cognitive-teardown-of-the-user-experience-ux/

5. https://technical.ly/uncategorized/nyu-game-center-flappy-bird-case-study/
6. https://www.theverge.com/2014/6/4/5776232/temple-run-1-billion-downloads
