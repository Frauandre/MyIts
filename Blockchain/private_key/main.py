import binascii
from hashlib import sha256, new
import base58 as base58
import ecdsa

if __name__ == '__main__':
    '''
    Codice preso da:
    https://medium.com/coinmonks/bitcoin-address-generation-on-python-e267df5ff3a3
    '''

    ecdsaPrivateKey = ecdsa.SigningKey.generate(curve=ecdsa.SECP256k1)

    ecdsaPublicKey = '04' + ecdsaPrivateKey.get_verifying_key()\
                                           .to_string()\
                                           .hex()

    hash256FromECDSAPublicKey = sha256(binascii.unhexlify(ecdsaPublicKey)).hexdigest()

    ridemd160FromHash256 = new('ripemd160', binascii.unhexlify(hash256FromECDSAPublicKey))

    prependNetworkByte = '00' + ridemd160FromHash256.hexdigest()

    hash = prependNetworkByte
    for x in range(1, 3):
        hash = sha256(binascii.unhexlify(hash)).hexdigest()


    cheksum = hash[:8]

    appendChecksum = prependNetworkByte + cheksum

    bitcoinAddress = base58.b58encode(binascii.unhexlify(appendChecksum))

    print("Bitcoin Address: ", bitcoinAddress.decode('utf8'))