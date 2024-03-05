Media Application README
Overview
This media application provides an integrated platform for users to manage and play audio files. It features a comprehensive user interface for login, signup, main application functionality, and audio file management through custom user controls.

Features

Login Form: Secure login functionality with error handling for incorrect credentials.
Signup Form: User registration with validation checks for data integrity.
Main Form (Form1): Core application interface that dynamically loads audio files associated with the logged-in user, allowing for playback and file management.
Player User Control: Custom control for audio file playback, including functionalities for play, stop, and file deletion from the database.

Technical Details
Uses LocalDB for user and file data management.
Supports .wav audio file format for upload and playback.
Implements SoundPlayer for audio functionalities.
Utilizes SqlConnection for database interactions.

Setup
Ensure .NET Framework and LocalDB are installed.
Compile the solution in Visual Studio.
Run the application and follow the on-screen instructions to login or sign up.

Usage
Login/Signup: Access the application by logging in or signing up.
Upload Files: From the main interface, users can upload .wav files to their account.
Manage Audio: Play or delete audio files directly from the main interface.

Contributions
used for some UI elements
https://github.com/ComponentFactory/Krypton

License
This project is licensed under the MIT License - see the LICENSE file for details.
