# Desktop-App
Windows Desktop App for form submissions using Visual Basic
## Prerequisites
- Visual Studio (not Visual Studio Code)
- .NET Framework
- Backend server running on `http://localhost:3000`

## Installation

1. **Clone the repository:**

   ```sh
   git clone https://github.com/bhavi7023/Desktop-App
   Open the project:
2.Open Visual Studio.
  Click on File > Open > Project/Solution.
  Navigate to the project directory and select the .sln file.
  **Usage**
     1.Run the Backend Server:
      Ensure your backend server is running. The backend server should be available at 'http://localhost:3000'.

    2.Run the Windows Forms App:
      Press 'F5' in Visual Studio to build and run the application.
**Features**
    MainForm
      View Submissions: Opens the 'ViewSubmissionsForm' to navigate through submitted forms.
      Create New Submission: Opens the 'CreateSubmissionForm' to submit a new form.
ViewSubmissionsForm
      Previous: Navigate to the previous submission.
      Next: Navigate to the next submission.
CreateSubmissionForm
      Name, Email, Phone, GitHub Link: Input fields for form submission.
      Stopwatch: Button to start/stop the stopwatch.
      Submit: Submit the form data to the backend.
      Ctrl+S: Keyboard shortcut to submit the form.
Keyboard Shortcuts
      Ctrl+S: Submit the form on the CreateSubmissionForm page.
**Contributing**
      If you wish to contribute, please fork the repository and create a pull request with your changes.
