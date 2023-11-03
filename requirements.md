Requirements
User should be able to login/signup
App should be able to match 2 online users who requested for a match.
App should create a game for users
App should assign color(White or Black) to each player
App should Init chess board.
User should be able to move a chess piece from one cell to another.
Game should check is this is a valid move
Game should check state of the board
Game should announce winner and stop game whenever can.
Game should continue until one user is a winner.
User should be forced to follow all chess rules.





Object/Class Identification:

App
Game
Board
Piece


User
Player
Color







Activities by all actors (Activity Diagram)




                                                    Assign color to user
User    -------->   Login
                    Request Game       ------       Init game                     <--------------- App
                    Move on turn                    Add user in game
                                                    Print board state
                                                    Declare Winner
                    