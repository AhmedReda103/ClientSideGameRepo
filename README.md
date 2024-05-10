# Project: Client/Server Application (Guess the Name)

## Description
This project is a client/server application developed using Windows Forms and C#. It allows multiple players to connect to a server and play a game of "Guess the Name". The game involves guessing characters in a selected word, with synchronized graphical interfaces between players.

## Technologies Used
- Windows Forms
- C#
- Sockets
- TCP client
- Multithreading

## Key Features
- **Player Management:** The server maintains a list of connected players, facilitating login and access to available rooms.
- **Room Creation and Joining:** Players can create or join existing rooms, with options to configure game settings such as category selection.
- **Gameplay:** Players take turns guessing characters in a word, with interfaces synchronized between players. Logic for switching active players based on correct/incorrect guesses is implemented.
- **End of Game Scenarios:** Messages are displayed at the end of each game, offering options for players to start a new game or leave the room.
- **Watching Games:** Players can join rooms to spectate ongoing games, with real-time updates on the interface.
- **Result Storage:** Game results are stored in a text file on the server, documenting player names and outcomes.
