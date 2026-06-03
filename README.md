# WinForms C# Desktop Calculator

A robust graphical desktop calculator application built using C# and Windows Forms (WinForms). This utility demonstrates object-oriented programming principles, event-driven architecture, and custom string-based mathematical evaluation in a .NET environment.

---

## 🚀 Key Features

*   **Standard Desktop Interface:** Features a clean, intuitive UI with a primary display screen (`textBox1`) and a standard numerical keypad layout.
*   **Basic Arithmetic:** Supports standard mathematical operations including Addition (`+`), Subtraction (`-`), Multiplication (`*`), and Division (`/`).
*   **Advanced Operations:** Includes Square Root calculation (√), Multiplicative Inverse (`1/x`), and Percentage computations (`%`).
*   **Input Management:** Provides comprehensive input controls such as Backspace (`←`) to remove the last character, Clear Entry (`CE`) to remove the active operand, and Clear (`C`) to completely reset the current display.
*   **Safe Error Handling:** Implements logical checks for invalid mathematical operations, safely outputting "Eroare" for actions like calculating the square root of a negative number or attempting to find the inverse of zero.

---

## 🛠️ Technology Stack

*   **Language:** C#
*   **UI Architecture:** Windows Forms Application
*   **Core Libraries:** `System`, `System.Windows.Forms`, `System.Drawing`

---

## 💻 Implementation Details

The application separates UI design from core logic, handling calculations through an event-driven model combined with custom string parsing techniques:

*   **Event-Driven Logic:** Each UI button is mapped to a specific event handler (e.g., `b0_Click`, `bPlus_Click`, `bRadical_Click`) that dynamically updates the main display.
*   **String Parsing Evaluation:** The core calculation logic inside the Equals button (`bEgal_Click`) relies entirely on string manipulation. It extracts the raw text, manages negative number edge-cases by checking index positions, splits the string based on the detected arithmetic operator, and computes the final floating-point result using `Convert.ToDouble()`.
*   **State Management:** The application effectively tracks and manages negative prefixes natively within the text stream and allows for real-time input correction without crashing the application state.
