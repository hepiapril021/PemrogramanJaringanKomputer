#include <iostream>
#include <string>
using namespace std;

int main() {
	string username;
	string password;
	
	cout << "==========REGISTRATION USER==========" << endl <<endl;

	cout << "Create a Username : ";
	cin >> username;

	cout << "Create a Password : ";
	cin >> password;
	cout << endl;

	

	if (password.size() <= 7 ) {
		cout << "Your data is incomplete, password must be more than 7 characters"  << endl;
	}
	else
	{
		cout << "your data has been received by the server"<< endl;
		cout << "========================================="<<endl;
		string Merge = username + password;
		cout << Merge << endl;
		cout << "(" << username.length() << ") <-- this is user" 
			<< " (" << password.size() << ") <-- this is password" <<endl ;
		
	}
	
	return 0;
}