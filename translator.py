import sys
from googletrans import Translator
n = len(sys.argv)
if n == 4:
   translator = Translator()
   translation = translator.translate(sys.argv[1], src=sys.argv[2], dest=sys.argv[3])
   print(translation.text)
else:
   print("\033[91mInvalid number of arguments\033[0m")