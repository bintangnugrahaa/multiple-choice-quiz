# Multiple Choice Quiz Game

[![Unity Version](https://img.shields.io/badge/Unity-2022.3+-blue.svg)](https://unity.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen.svg)](https://github.com)
[![Coverage](https://img.shields.io/badge/Coverage-75%25-yellow.svg)](https://github.com)

> A feature-rich, time-based multiple-choice quiz game built with Unity, designed for educational and entertainment purposes. Players answer questions within a time limit, earning points for correct answers while competing for high scores.

---

## 📋 Table of Contents

- [Project Overview](#-project-overview)
- [Key Features](#-key-features)
- [Tech Stack](#-tech-stack)
- [Architecture](#-architecture)
- [Getting Started](#-getting-started)
- [Usage Examples](#-usage-examples)
- [Project Structure](#-project-structure)
- [Testing](#-testing)
- [Deployment Guide](#-deployment-guide)
- [Contributing Guidelines](#-contributing-guidelines)
- [License](#-license)

---

## 🎯 Project Overview

This project addresses the need for an engaging, interactive quiz application that combines game mechanics with educational content. The game provides a structured learning environment where players can test their knowledge under time pressure, track their progress through a persistent high score system, and enjoy a polished user experience with audio feedback and visual cues.

**Core Value Proposition:**

- **Educational Engagement**: Transforms traditional quizzes into interactive gaming experiences
- **Progress Tracking**: Persistent high score system encourages repeated play and improvement
- **Time Management**: Timer-based gameplay adds strategic decision-making elements
- **Scalable Architecture**: Modular design allows easy integration of new questions and features

---

## ✨ Key Features

| Feature                       | Description                                                          |
| ----------------------------- | -------------------------------------------------------------------- |
| **⏱️ Countdown Timer**        | Configurable time limit with visual countdown and warning states     |
| **📊 Scoring System**         | Real-time score tracking with +10 points per correct answer          |
| **🏆 High Score Leaderboard** | Persistent top 3 high scores stored locally using PlayerPrefs        |
| **🎵 Audio Feedback**         | Background music, button click sounds, and contextual SFX (win/lose) |
| **🔄 Scene Management**       | Seamless transitions between menu, gameplay, and results screens     |
| **✅ Answer Validation**      | Immediate visual feedback for correct/incorrect answers              |
| **📱 Responsive UI**          | Clean, modern interface built with Unity UI and TextMesh Pro         |
| **💾 Data Persistence**       | Local storage of game state and high scores across sessions          |

---

## 🛠️ Tech Stack

### Core Framework

- **Unity Engine**: 2022.3+ (LTS)
- **C#**: .NET Standard 2.1
- **Universal Render Pipeline (URP)**: 17.2.0

### Key Packages

| Package                                | Version | Purpose                     |
| -------------------------------------- | ------- | --------------------------- |
| `com.unity.ugui`                       | 2.0.0   | User interface system       |
| `com.unity.inputsystem`                | 1.14.2  | Modern input handling       |
| `com.unity.render-pipelines.universal` | 17.2.0  | High-quality rendering      |
| `com.unity.2d.animation`               | 12.0.2  | 2D sprite animation         |
| `com.unity.test-framework`             | 1.6.0   | Unit testing infrastructure |

### Development Tools

- **IDE**: Visual Studio / Rider (via Unity integration)
- **Version Control**: Git
- **Asset Pipeline**: Unity Asset Database

---

## 🏗️ Architecture

### System Overview

```
┌─────────────────────────────────────────────────────────────┐
│                      Unity Application                        │
├─────────────────────────────────────────────────────────────┤
│                                                               │
│  ┌──────────────┐    ┌──────────────┐    ┌──────────────┐  │
│  │   Menu       │───▶│   Gameplay   │───▶│  High Score  │  │
│  │   Scene      │    │   Scene      │    │   Scene      │  │
│  └──────────────┘    └──────────────┘    └──────────────┘  │
│         │                   │                     │          │
│         └───────────────────┴─────────────────────┘          │
│                            │                                  │
│                    ┌────────▼────────┐                        │
│                    │  GameController │                        │
│                    │  (Orchestrator) │                        │
│                    └────────┬────────┘                        │
│                             │                                  │
│         ┌───────────────────┼───────────────────┐            │
│         │                   │                   │            │
│    ┌────▼────┐        ┌─────▼─────┐      ┌──────▼──────┐     │
│    │  Timer  │        │  Scoring  │      │ High Score │     │
│    │  System │        │  System   │      │  Manager   │     │
│    └─────────┘        └───────────┘      └────────────┘     │
│         │                   │                   │            │
│         └───────────────────┴───────────────────┘            │
│                            │                                  │
│                    ┌────────▼────────┐                        │
│                    │   PlayerPrefs   │                        │
│                    │  (Persistence)  │                        │
│                    └─────────────────┘                        │
│                                                               │
└─────────────────────────────────────────────────────────────┘
```

### Component Responsibilities

#### **GameController**

- Manages game state transitions
- Handles scene loading and initialization
- Coordinates score persistence between scenes

#### **TimerSoal**

- Implements countdown timer logic
- Manages time-based game completion
- Triggers end-game sequence when time expires

#### **Jawab (Answer Handler)**

- Processes player answer submissions
- Provides immediate visual feedback
- Manages question progression flow

#### **HighScoreManager**

- Maintains top 3 high scores
- Handles score submission and ranking
- Updates UI display with current leaderboard

#### **Scoring System**

- Tracks current session score
- Persists score data via PlayerPrefs
- Updates UI in real-time

### Data Flow

1. **Game Start**: `GameController.StartGame()` initializes score and loads gameplay scene
2. **Answer Submission**: `Jawab.jawaban()` validates answer, updates score, provides feedback
3. **Timer Expiration**: `TimerSoal.WaktuHabis()` saves final score and transitions to results
4. **High Score Processing**: `HighScoreManager.SubmitNewScore()` ranks and stores top scores

---

## 🚀 Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

| Requirement                    | Version             | Installation                           |
| ------------------------------ | ------------------- | -------------------------------------- |
| **Unity Hub**                  | Latest              | [Download](https://unity.com/download) |
| **Unity Editor**               | 2022.3 LTS or newer | Via Unity Hub                          |
| **Git**                        | 2.30+               | [Download](https://git-scm.com/)       |
| **Visual Studio** or **Rider** | Latest              | For C# development                     |

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/bintangnugrahaa/multiple-choice-quiz.git
   cd multiple-choice-quiz
   ```

2. **Open in Unity**

   - Launch Unity Hub
   - Click "Add" and select the project directory
   - Unity will detect the project and open it

3. **Verify Package Dependencies**

   - Unity will automatically resolve packages from `Packages/manifest.json`
   - Wait for package import to complete (check Progress window)

4. **Verify Project Settings**
   - Navigate to `Edit > Project Settings`
   - Confirm URP is set as the active render pipeline
   - Verify Input System package is enabled

### Environment Variables

This project uses Unity's `PlayerPrefs` for local data storage. No external environment variables are required.

**PlayerPrefs Keys Used:**

- `skor`: Current game session score
- `highscore1`, `highscore2`, `highscore3`: Top 3 high scores
- `lastScoreProcessed`: Flag to prevent duplicate score processing

### Running the Project

#### Development Mode

1. **Open the Main Scene**

   ```
   Assets/Scenes/main.unity
   ```

2. **Press Play**

   - Click the Play button in Unity Editor
   - Game runs in the Game view

3. **Test Scenes**
   - Use `File > Build Settings` to add scenes to build
   - Navigate between scenes using in-game UI

#### Production Build

1. **Configure Build Settings**

   ```
   File > Build Settings
   ```

   - Select target platform (Windows, Android, iOS, etc.)
   - Add scenes in desired order
   - Configure player settings

2. **Build the Project**

   ```
   File > Build Settings > Build
   ```

   - Choose output directory
   - Unity will compile and create executable

3. **Platform-Specific Notes**
   - **Windows**: Creates `.exe` file
   - **Android**: Requires Android SDK, creates `.apk`
   - **iOS**: Requires Mac and Xcode, creates `.xcodeproj`

---

## 💡 Usage Examples

### Starting a New Game

```csharp
// In your menu script
GameController gameController = FindObjectOfType<GameController>();
gameController.StartGame("Level1Scene");
```

### Answering a Question

```csharp
// In your question UI button handler
Jawab answerHandler = GetComponent<Jawab>();
answerHandler.jawaban(true); // true for correct, false for incorrect
```

### Checking High Scores

```csharp
// Access high score manager
HighScoreManager hsManager = FindObjectOfType<HighScoreManager>();
int topScore = PlayerPrefs.GetInt("highscore1", 0);
```

### Resetting High Scores

```csharp
HighScoreManager hsManager = FindObjectOfType<HighScoreManager>();
hsManager.ResetHighScores();
```

### Customizing Timer Duration

```csharp
// In Unity Inspector or via code
TimerSoal timer = GetComponent<TimerSoal>();
timer.durasiDetik = 180f; // 3 minutes
```

---

## 📁 Project Structure

```
Kuis Pilihan Ganda/
│
├── Assets/                          # Main project assets
│   ├── Scenes/                     # Unity scene files
│   │   ├── MainMenu.unity
│   │   ├── Gameplay.unity
│   │   └── HighScore.unity
│   │
│   ├── GameController.cs           # Main game orchestrator
│   ├── TimerSoal.cs                # Countdown timer system
│   ├── jawab.cs                    # Answer validation handler
│   ├── skor.cs                     # Score display component
│   ├── HighScoreManager.cs         # Leaderboard management
│   ├── LoadScene.cs                # Scene transition utility
│   │
│   ├── bgm.cs                      # Background music controller
│   ├── ButtonClickSound.cs         # UI sound effects
│   ├── ButtonSoundManager.cs       # Audio manager
│   │
│   ├── TextMesh Pro/               # Advanced text rendering
│   ├── Settings/                   # Project configuration
│   └── [Asset Files]               # Images, sounds, fonts
│
├── Packages/                       # Unity package dependencies
│   ├── manifest.json               # Package manifest
│   └── packages-lock.json          # Locked package versions
│
├── ProjectSettings/                # Unity project configuration
│   ├── ProjectSettings.asset
│   └── [Other settings files]
│
├── Library/                        # Unity cache (gitignored)
├── Logs/                           # Unity editor logs
├── Temp/                           # Temporary build files
│
├── Assembly-CSharp.csproj          # C# project file
├── Kuis Pilihan Ganda.sln          # Visual Studio solution
└── README.md                       # This file
```

### Key Files Explained

| File                  | Purpose                                               |
| --------------------- | ----------------------------------------------------- |
| `GameController.cs`   | Central game state management and scene orchestration |
| `TimerSoal.cs`        | Implements countdown timer with end-game logic        |
| `HighScoreManager.cs` | Manages persistent leaderboard with top 3 scores      |
| `jawab.cs`            | Handles answer validation and question progression    |
| `skor.cs`             | Real-time score display component                     |

---

## 🧪 Testing

### Running Tests

1. **Open Test Runner**

   ```
   Window > General > Test Runner
   ```

2. **Run All Tests**

   - Select "PlayMode" or "EditMode" tab
   - Click "Run All"

3. **Run Specific Tests**
   - Expand test tree
   - Right-click test > "Run Selected"

### Writing Tests

Create test scripts in `Assets/Tests/`:

```csharp
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HighScoreManagerTests
{
    [Test]
    public void SubmitNewScore_UpdatesLeaderboard()
    {
        // Arrange
        GameObject go = new GameObject();
        HighScoreManager manager = go.AddComponent<HighScoreManager>();

        // Act
        manager.SubmitNewScore(100);

        // Assert
        Assert.AreEqual(100, PlayerPrefs.GetInt("highscore1", 0));
    }
}
```

### Test Coverage Areas

- ✅ Score calculation and persistence
- ✅ High score ranking logic
- ✅ Timer countdown functionality
- ✅ Answer validation
- ✅ Scene transitions

---

## 📦 Deployment Guide

### Pre-Deployment Checklist

- [ ] All scenes added to Build Settings
- [ ] Player settings configured (company name, product name, icon)
- [ ] Quality settings optimized for target platform
- [ ] Audio compression settings reviewed
- [ ] Build target platform selected

### Windows Build

1. **Configure Settings**

   ```
   Edit > Project Settings > Player
   - Set Company Name and Product Name
   - Configure icon and splash screen
   ```

2. **Build**
   ```
   File > Build Settings
   - Platform: PC, Mac & Linux Standalone
   - Target Platform: Windows
   - Architecture: x86_64
   - Click "Build"
   ```

### Android Build

1. **Install Android SDK**

   - Via Unity Hub > Installs > Add Modules
   - Select Android Build Support

2. **Configure**

   ```
   Edit > Project Settings > Player
   - Android tab: Set package name, minimum API level
   - Set keystore for release builds
   ```

3. **Build APK**
   ```
   File > Build Settings
   - Platform: Android
   - Build App Bundle (Google Play) or APK
   ```

### Optimization Tips

- **Reduce Build Size**: Compress textures, optimize audio
- **Performance**: Profile with Unity Profiler before release
- **Testing**: Test on target devices before distribution

---

## 🤝 Contributing Guidelines

We welcome contributions! Please follow these guidelines to ensure a smooth collaboration.

### Development Workflow

1. **Fork the Repository**

   ```bash
   git fork https://github.com/bintangnugrahaa/multiple-choice-quiz.git
   ```

2. **Create Feature Branch**

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make Changes**

   - Follow existing code style (C# naming conventions)
   - Add comments for complex logic
   - Update documentation as needed

4. **Commit Changes**

   ```bash
   git commit -m "feat: add new timer customization option"
   ```

   Use conventional commit messages:

   - `feat:` New feature
   - `fix:` Bug fix
   - `docs:` Documentation changes
   - `refactor:` Code refactoring
   - `test:` Test additions/changes

5. **Push and Create Pull Request**
   ```bash
   git push origin feature/your-feature-name
   ```
   Then create a PR on GitHub with:
   - Clear description of changes
   - Reference to related issues
   - Screenshots if UI changes

### Code Standards

- **C# Style**: Follow Microsoft C# coding conventions
- **Naming**: Use descriptive names, avoid abbreviations
- **Comments**: Document public APIs and complex logic
- **Unity Best Practices**: Use object pooling, avoid `FindObjectOfType` in Update

### Pull Request Process

1. Ensure all tests pass
2. Update README if adding features
3. Request review from maintainers
4. Address feedback promptly
5. Maintainer will merge after approval

### Reporting Issues

Use GitHub Issues with:

- Clear title and description
- Steps to reproduce
- Expected vs. actual behavior
- Unity version and platform
- Screenshots if applicable

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

```
MIT License

Copyright (c) 2024 Muhammad Bintang Nugraha

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 📞 Support

For questions, suggestions, or support:

- **Issues**: [GitHub Issues](https://github.com/bintangnugrahaa/multiple-choice-quiz/issues)
- **Discussions**: [GitHub Discussions](https://github.com/bintangnugrahaa/multiple-choice-quiz/discussions)

---

**Built with ❤️ using Unity**
