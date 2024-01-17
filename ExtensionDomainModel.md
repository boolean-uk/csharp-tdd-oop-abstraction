# Extension - Domain Model
```
As a system administrator,
I want my users to have to create a user account with an email address and a password.

I want them to receive an "invalid password" message if they provide a
password less than 8 characters in length.

I want them to receive an "invalid email" message if they provide an email
address without an @ symbol in it.

I want new accounts to be disabled by default until I manually set them as enabled.

I want users to know if they are able to log in or not based on whether their
account is enabled or disabled.
```
<table>
	<thead>
		<td>Class</td>
		<td>Method</td>
		<td>Description</td>
		<td>Output Type</td>
	</thead>
	<tbody>
		<td><code>Account</code></td>
		<td><code>IsValidPassword(string password)</code></td>
		<td>Checks whether a given string is a valid password</td>
		<td>bool</td>
	</tbody>
	<tbody>
		<td></td>
		<td><code>IsValidEmail(string email)</code></td>
		<td>Checks whether a given string is a valid email</td>
		<td>bool</td>
	</tbody>
	<tbody>
		<td></td>
		<td><code>IsEnabled</code></td>
		<td>Returns whether an account is enabled or disabled</td>
		<td>bool</td>
	</tbody>
	<tbody>
		<td><code>IUser</code></td>
		<td><code>CreateAccount(string email, string password)</code></td>
		<td>Lets the user create an account</td>
		<td>Account</td>
	</tbody>
	<tbody>
		<td></td>
		<td><code>LogIn(string email, string password)</code></td>
		<td>Lets the user log in as long as the email and password is correct, and the account is enabled</td>
		<td></td>
	</tbody>
	<tbody>
		<td><code>Administrator : IUser</code></td>
		<td><code>EnableAccount(Account account)</code></td>
		<td>Lets the administrator enable an account</td>
		<td>void</td>
	</tbody>
		<tbody>
		<td><code>User : IUser</code></td>
		<td></td>
		<td></td>
		<td></td>
	</tbody>
</table>