# 📊 CalculateFinalGPA

This is a C# console application that allows users to input a student's subject names and corresponding marks, automatically evaluates their performance using a credit and point system, and determines their academic progression status based on clear rules.

The goal of this program is to simulate how a student's General Performance Assessment (GPA) might be calculated, with a final determination of whether the student is **Progressing** or **Not Progressing**, based on:

- Performance in **Home Language**
- Number of failed subjects under 40%
- Number of critically failed subjects under 30%

Upon running the program, it prompts the user to enter the student’s full name, followed by seven subjects and their corresponding marks. It then:

- Assigns a **Credit** (A to G) and a **Point** (1 to 7) to each subject
- Displays a final report showing the breakdown
- Calculates the total marks and total points
- Evaluates if the student is **Progressing** or **Not Progressing**

The progression rules are as follows:

- If the Home Language mark is less than 40%, the student is **Not Progressing**
- If the student scores less than 40% in **three or more subjects**, the student is **Not Progressing**
- If the student scores less than 30% in **three or more subjects**, the student is **Not Progressing**
- In all other cases, the student is **Progressing**

Here is the Credit and Point scale:

| Marks       | Credit | Point |
|-------------|--------|-------|
| 0 - 29      | G      | 1     |
| 30 - 39     | F      | 2     |
| 40 - 49     | E      | 3     |
| 50 - 59     | D      | 4     |
| 60 - 69     | C      | 5     |
| 70 - 79     | B      | 6     |
| 80 - 100    | A      | 7     |


## 🛠️ Tech Stack

- Language: **C#**
- Platform: **.NET SDK / .NET Core**
- Execution: **Console App**



## ▶️ How to Run

1. Make sure you have the .NET SDK installed.
2. Clone this repository:
   ```bash
   git clone https://github.com/your-username/CalculateFinalGPA.git
   cd CalculateFinalGPA
   ```
3. Run the app using the .NET CLI:
```bash
  dotnet run
  ```
👤 **Author**  
Khuliso John  
Made for learning, growth, and purpose.

"Intelligence plus character—that is the goal of true education." – Martin Luther King Jr.

📜 **License**  
This project is open-source. Feel free to modify and reuse as needed.


