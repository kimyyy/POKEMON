#coding:utf-8
import urllib.request
import requests
from bs4 import BeautifulSoup
import csv
url = "https://yakkun.com/sm/move_list.htm?cat=2"
html = urllib.request.urlopen(url)
soup = BeautifulSoup(html, "html.parser")

trs = soup.find_all("tr", class_ = "c1")

names = []
f = open('mochimono.csv', 'a')
writer = csv.writer(f, lineterminator = '\n')
for tr in trs:
    try:
        props = []
        props.append(tr.a.string)
        tds = tr.find_all("td")
        count = 0
        for td in tds:
            if not td.span == None:
                props.append(td.span.string)
            else:
                count+=1
                if count == 2:
                    props.append(td.string)
                    break
        for prop in props:
            prop.encode('utf8')
        writer.writerow(props)
    except:
        pass
f.close()