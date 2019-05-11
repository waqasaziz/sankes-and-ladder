# sankes-and-ladder
This solution is produced in C# using .Net standard 1.6 ad Visual Studio 2017. There are two projects, first a class library which contains game logic and other is a Xunit test project containg Phase 1 related tests.

# Key Decisions
 * The solution is a class library. This makes it very open for consumer of this solution to integrate it to any UI.
 * .Net Standard is used instead of .Net Core. This is to make this solution targetable to both Full .Net Framework and .Net Core.
 * TDD first apprach is adopted to ensure key requirements are identified and written down.
