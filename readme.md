## BIP-39 Phrase Reader

### Overview
This C# console application generates BIP-39 compliant mnemonic phrases based on 12-bit binary input. BIP-39 is commonly used in the cryptocurrency space for creating deterministic wallets.

### Features
- Reads a file containing a list of BIP-39 English words.
- Requests 12 binary inputs from the user, validating each input.
- Converts binary input to an integer and maps it to the corresponding BIP-39 word.
- Ensures the generated phrases are within the valid range of BIP-39 words.

### Usage
1. Ensure you have the .NET 8 SDK installed.
2. Clone the repository by running: git clone https://github.com/Raphael-Afonso/bip-39-binary-reader
3. Navigate to the project directory: cd bip-39-binary-reader
4. Build and run the application using the following commands:
```
dotnet build
dotnet run
```
5. Enter 12-bit binary sequences when prompted.
6. The program converts the binary input to a BIP-39 mnemonic phrase and displays the result.

### Dependencies
- .NET SDK 8.0+

### Contributing
Contributions are welcome! Feel free to open issues or pull requests.

### License
This project is licensed under the MIT License.