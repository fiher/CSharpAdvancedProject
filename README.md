# CSharpAdvancedProject - Encryption algorithm

<div><h2>What is the project about?</h2></div>
</br>
<div><h5>The project is encrypting algorithm made with the idea to serve as back up encryption. What this means is that it is used before the main algorithm for encrypting data is used in order to make the life of a hacker into a living hell.</h5></div>
<div><h3>How did we achieved our goal?</h3></div>
</br>
<div><h5><i> The algorithm uses a sequence to mess up the text. The sequence represents certain order in which different methods are invoked. The sequence determines what the algorithm will do and how hell it will do it. Changing the sequence changes the algorithm to a level it is imposible to compare one version with another. This means that if you download it and change the sequence you will have your own version which no one else will have. By doing this, you will make it impossible for a hacker to hack it, since he/she would have no ide how the text was encrypted, as long as he/she doesn't have access to your server. If they do - you are doomed anyway since every encryption is made to be decrypted and if they have access and know all of the keys and algorithms - you stand no chance in protecting your data.</i><h5></div>
</br>
<div><h2> The team:<h2></div>
<div>
<h5> Павлин Петков (github: https://github.com/fiher ) <h5>
<h4>Contribution:</h4><h5>Made most of the code and also responsible for the idea</h4>
</div>
</br>
<div>
<h5> Кристиян Памидов (github: https://github.com/ChrisPam ) <h5>
<h4>Contribution:</h4><h5>Made one of the cyphers and decyphers.</h4>
</div>
</br>
<div>
<h2>How to run it?<h2>
</div>
<div>
<h4>After download you want to go to **EncryptionAlgorithm->Program.cs** and hit **CTRL + F5** . If you want to change the way the algorithm works you need to go to **EncryptionAlgorithm->Encryption.cs**. There you will find private variable "sequence" containing numbers from 0 to 5 represented as a long string. You can change it anyway you want as long as you follow these rules:
<ul>
<li>It must contain only numbers from 0 to 5 and nothing else!</li>
<li>Don't use the number 2 more than twice as it is used to insert things into the text and make it bigger</li>
<li>Don't forget to copy it at the end and go to EncryptionAlgorithm->Decryption.cs to paste it there as the two sequences must be identical</li></ul>
If those rules are followed the code must run correctly. <h3>Bear in mind that you can change the <i>secretKey</i> variable as well, but also you have to remember to paste it in the Decryption class, as both classes must have identical private variables to run correctly!<h3><h5>
</div>
