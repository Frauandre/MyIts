import unittest

def return_add(a, b):
    return a+b

def return_Load():
    return True

class MyTestCase(unittest.TestCase):
    def test_add(self):
        self.assertEqual(return_add(5, 2),7)

    def test_load(self):
        self.assertEqual(return_load())


if __name__ == '__main__':
    unittest.main()
