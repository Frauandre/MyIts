from hashlib import sha256
from os import listdir
import os.path

# Prendo tutti i file nella cartella tranne questo script in python
script_dir = os.path.dirname(__file__)
files = [f for f in listdir(script_dir) if f != os.path.basename(__file__)]

# Ordino i file per nome
files.sort()
print("File in input del Merkle Tree:")
print(files)

if (len(files) % 2 != 0):
    print("Errore: il numero di file deve essere pari")
    exit(1)

# Calcolo i valori SHA256 di ogni file
hashes = []
for f in files:
    content = ''
    with open(f, 'r') as file:
        content += file.read()
    hashes.append(sha256(content.encode('utf-8')).hexdigest())

print("SHA256 dei file:")
print(hashes)

# Calcolo il merkle tree root
merkle = hashes
while len(merkle) > 1:
    new_merkle = []
    for i in range(0,len(merkle),2):
        content = merkle[i] + merkle[i+1] 
        new_merkle.append(sha256(content.encode('utf-8')).hexdigest())
    merkle = new_merkle

print("Merkle tree root: " + merkle[0])

