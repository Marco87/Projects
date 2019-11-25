from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time
import random

class InstagramBot:
    def __init__(self, username, password):
        self.username = username
        self.password = password
        self.driver = webdriver.Firefox(executable_path=r'geckodriver')

    def login(self):
        driver = self.driver
        driver.get('https://www.instagram.com')
        time.sleep(3)
        login_button = driver.find_element_by_xpath("//a[@href='/accounts/login/?source=auth_switcher']")
        login_button.click()
        user_element = driver.find_element_by_xpath("//input[@name='username']")
        user_element.clear()
        user_element.send_keys(self.username)
        password_element = driver.find_element_by_xpath("//input[@name='password']")
        password_element.clear()
        password_element.send_keys(self.password)
        password_element.send_keys(Keys.RETURN)
        time.sleep(5)
        self.curtir_fotos('gospel')

    def curtir_fotos(self, hashtag):
        driver = self.driver
        driver.get('https://instagram.com/explore/tags/' + hashtag + '/')
        time.sleep(5)
        for i in range(1, 3):
            driver.execute_script("window.scrollTo(0, document.body.scrollHeight);")
            time.sleep(5)



marcoBot = InstagramBot('pregandoemcena', 'paraquedista')
marcoBot.login()