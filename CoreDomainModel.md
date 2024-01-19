User Story

I want to see a Date and Time the task was created but I do not want it changed.

Class			Methods
TodoItem		bool AddTask(string title, string detail, int date, int time, bool 				isDone = false)
			bool SetTaskComplete()
			bool SetTaskIncomplete()
			bool IsTaskDone()
			bool AddDetails(string message)
			void PrintDateAndTime()
			

Scenario				Output
Adds the task items			True if action was successful
Sets the task status to complete		True if action was successful
Sets the task status to incomplete	True if action was successful
Returns the task status			True or false
Adds the string onto the details		True if action was successful
Returns the date and time		An output to the terminal
