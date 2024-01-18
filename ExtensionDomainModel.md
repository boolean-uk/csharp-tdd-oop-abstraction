|Type|Class|Member|Method|Scenario|Output|
|:----|:----|:----|:----|:----|:----|
| |User|email, password, disabled| | | |
| | | |User(name, email)| | |
| | | | |invalid password|Exception?|
| | | | |invalid email|Exception?|
| | | | |Success|Create disabled user|
| | | |bool Login()|possible if disabled is false|return true|
| | | | |not possible if false|return false|
