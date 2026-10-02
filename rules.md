C# Project Rules
Naming Conventions
NC001
Class names must use PascalCase.

NC002
Method names must use PascalCase and start with a verb.

NC003
Property names must use PascalCase.

NC004
Private fields must start with an underscore (_).

NC005
Local variables and method parameters must use camelCase.

NC006
Constants must use PascalCase.

NC007
Interface names must start with the letter "I".

NC008
Namespace names must match the folder structure.

Namespace Rules
NS001
All files must use file-scoped namespaces.

NS002
A solution must not mix file-scoped and block-scoped namespaces.

Class Rules
CR001
Only one public class is allowed per file.

CR002
Classes containing only constants must be declared static.

CR003
Every public class must have XML documentation.

CR004
A class must have a single responsibility.

CR005
Class names must clearly describe their purpose.

Method Rules
MR001
Every public method must have XML documentation.

MR002
Methods must not exceed 25 lines of code.

MR003
Methods must perform a single responsibility.

MR004
Methods must validate input parameters.

MR005
Methods must return early instead of using deeply nested conditions.

MR006
Methods must not contain duplicated logic.

MR007
Methods must not have more than four parameters.

MR008
Methods must use meaningful parameter names.

MR009
Methods must throw specific exceptions only.

MR010
Arithmetic operations that may overflow must be wrapped in checked blocks.

Exception Handling Rules
EH001
Catching System.Exception is prohibited.

EH002
Exceptions must contain meaningful messages.

EH003
Exceptions must never be swallowed.

EH004
Use "throw;" when rethrowing exceptions.

Logging Rules
LG001
All significant operations must be logged.

LG002
Structured logging must be used.

LG003
Sensitive information must never be logged.

LG004
Domain logic must not depend on logging implementations.

Code Quality Rules
CQ001
Unused using directives are prohibited.

CQ002
Magic strings are prohibited.

CQ003
Magic numbers are prohibited.

CQ004
Duplicate code is prohibited.

CQ005
Use string interpolation instead of string concatenation.

CQ006
Use readonly fields whenever possible.

CQ007
Nullable reference types must be explicitly declared.

CQ008
Avoid unnecessary comments that repeat code behaviour.

Architecture Rules
AR001
Program.cs must only contain application startup code.

AR002
Business logic must not be implemented in Program.cs.

AR003
Domain classes must not use Console.WriteLine.

AR004
User input must be validated before processing.

AR005
Business logic must reside in the Business Layer project.

AR006
Constants must be centralized in dedicated constants classes.

Documentation Rules
DOC001
Every public class must have XML documentation.

DOC002
Every public method must have XML documentation.

DOC003
Complex business logic must include explanatory comments.

Security Rules
SEC001
All external input must be validated.

SEC002
Internal exception details must not be exposed to end users.

SEC003
Credentials, secrets, and connection strings must not be hardcoded.

Formatting Rules
FR001
Opening braces must be placed on the same line as declarations.

FR002
Files must end with a newline.

FR003
Consecutive blank lines are limited to one.

FR004
Indentation must use four spaces.

FR005
Trailing whitespace is prohibited.