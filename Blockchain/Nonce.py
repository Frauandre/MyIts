from email.mime import base
from hashlib import sha256
from os import listdir
import os.path

if __name__=='__main__':
    base = int(input{'Insert base:'})
    exp = int(input{'Insert exp:'})
    target = pow(base, exp)
    str = input('Insert string:')

    nounce = -1
    while True:
        nounce+=1
        hash = sha256 (f'{str}{nounce}'.encode{'utf-8'}).hexdigest()
        print (f'{nounce}\n{hash}')
        if int(hash, 16) < target:
            break

print(f'Nounce that solve the problem: {nounce}')


