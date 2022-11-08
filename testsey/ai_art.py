#!C:\Users\YuSeungjun\anaconda3\python.exe
print("content-type: text/html; charset=utf-8\n")
#-*- coding: utf-8 -*-
import sys
import codecs
sys.stdout = codecs.getwriter("utf-8")(sys.stdout.detach())

print('''
<!DOCTYPE html>
<html lang="ko">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>AI_Art Disco Diffusion</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <header>
        <div class="logo">
            <a href="index.html"><img src="images/logo.png" alt="로고"></a>
        </div>
        <ul class="menu">
            <li><a href="#">로그인</a></li>
            <li><a href="#">회원가입</a></li>
            <li><button>생성하기</button></li>
        </ul>
    </header>
    <section class="Create_img">
        <div class="Create_box">
            <div class="main_text">
                <p>AI Art Disco Diffusion</p>
                <p>당신만의 이미지를 제작하세요</p>
            </div>
            <div class="text_prompt">
                <form action="process_create.py" method="POST">
                    <textarea name="content" id="" placeholder="prompt를 입력하세요."></textarea>
                    <input class="CreateBtn" type="submit" value="submit"></input>
                </form>
            </div>
            <div class="Set_box">
                <div class="style_box">
                    <img src="images/스타일.png" alt="스타일 이미지">
                    <p>스타일</p>
                </div>
                <div class="D_set_box">
                    <img src="images/세부설정.png" alt="세부 설정 이미지">
                    <p>세부 설정</p>
                </div>
            </div>
            <form action="process_create.py" method="POST">
                <input class="CreateBtn" type="submit" value="submit"></input>
            </form>
        </div>
    </section>
</body>
</html>
''')