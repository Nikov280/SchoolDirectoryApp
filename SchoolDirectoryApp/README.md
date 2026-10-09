# School Directory App

## Project Description
The School Directory App is a responsive Blazor Web Application designed to consume and display educational data from an external API. It provides users with a clean, interactive interface to view a comprehensive list of schools, perform real-time searches by school name, and view detailed information for each selected institution. Additionally, the application includes a dynamic School Statistics Dashboard that calculates key metrics (Total Schools, Unique Proprietors, and Email Availability) in real-time, also the app features a state-managed "Favorites" system that allows users to save and quickly access their preferred schools in a dedicated section. And Finally, a manual "Refresh" button provides a seamless way to reload API data and reset the view without refreshing the entire browser.

## Features
* **Live API Consumption:** Fetches and deserializes school data from a third-party endpoint.
* **Real-time Search & Filtering:** Dynamic list updating as the user types, with a quick-clear button.
* **State Management (Favorites):** Users can toggle schools as favorites, stored and accessible via a dedicated page.
* **School Statistics Dashboard:** Displays calculated metrics based on the retrieved dataset.
* **Data Refresh:** Built-in refresh button to request the latest data from the API with loading state feedback.
* **Responsive Design:** Optimized layout for both desktop and mobile devices using Bootstrap 5.

## Technologies Used
* **Framework:** .NET 10 / Blazor
* **Language:** C#
* **Frontend:** HTML, CSS, Bootstrap 5 (for responsive UI and styling)
* **Data Fetching:** HttpClient (REST API consumption)
* **State Management:** Custom AppStateService (Dependency Injection)

## API Endpoint Used
This application consumes data from the Edutots School API:
* `https://edutots.net/api/school`

## Instructions to Run the Application
1. **Clone the repository:**
   bash
   git clone [https://github.com/Nikov280/SchoolDirectoryApp.git]
