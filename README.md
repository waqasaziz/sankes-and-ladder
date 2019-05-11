# sankes-and-ladder
This solution is produced in C# using .Net standard 1.6 ad Visual Studio 2017. There are two projects, first a class library which contains game logic and second is a Xunit test project containing Phase 1 related tests.

# Key Decisions
 * The solution is a class library. This makes it very open for consumer of this solution to integrate it to any UI.
 * .Net Standard is used instead of .Net Core. This is to make this solution targetable to both Full .Net Framework and .Net Core.
 * TDD first apprach is adopted to ensure key requirements are identified and expected behaviour written down.
 * Constructor dependecny is used for DiceRoller to make it tranparent and open for consumer of this solution to pass any custom DiceRoller
 * Moq framework is used instead of a custom mock class for DiceRoller. This is to simplify the mocking behvaiour and to support any future complex testing scenarios
 
 # Game Feature Extension Ideas
   This solution is only implemented up to feature 1 of the game as per requiremnts document. Following can be implemented to further extend this solution: 
   * Introduce a constructor arugument for snakes position points as Dictionary<int,int> of numbers
   * Introduce a constructor arugument for ladder position points as Dictionary<int,int> of numbers
   * Introduce a constructor arugument for player as a collection of Player class
   * Implement PlayerTurn method to update curent player after each roll.
   * Update MoveToken logic to search in Sankes and Ladder dictionaries to further calculate position of token.
   

# Dependecies
 * .Net Standard 1.6
 * XUnit
 * moq
