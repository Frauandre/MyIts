import hashlib
print ("sha256")
def calc_sha256(filename):
with open (filename,"rb") as f:
    bytes = f.read
    readable_hash= hashlib.sha256(bytes).hexdigest()
print (readable_hash)
return readable_hash

def merkletree(f1,f2,f3,f4):

f1="bello.txt"
f2="apex.txt"
f3="tree.txt"
f4="power.txt"

f1tr=calc_sha256(f1)
f2tr=calc_sha256(f2)

print ("Risultato finale")

