Class(string email, string password)
	
	UserAccount

Properties
	
	public string Email {get: private set;}
	public string Password {get: private set;}
	public bool IsEnabled {get; private set;}

Methods

	public void EnableAccount()
		(enables account)
	public void DisableAccount()
		(Disables account)
	public void SetEmail(string email)
		(validates format of Email and sets new email if correct)
	private void SetPassword(string password)
		(sets new password if input fullfills requirements)
