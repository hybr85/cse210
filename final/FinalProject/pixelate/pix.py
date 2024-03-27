import sys
from PIL import Image
from numpy import round

LENGTH = 182
PIXL = 74

def main(args):
    im = Image.open(args[1])
    length = float(args[2])
    nl = length/LENGTH*PIXL
    w,h = im.size
    ratio = nl/w
    new_dims = [int(round(nl)),int(round(h*ratio))]
    print(length,new_dims)
    im.resize(new_dims).save(f"{args[1].split('.')[0]}-p.png")

if __name__ == "__main__":
    main(sys.argv)