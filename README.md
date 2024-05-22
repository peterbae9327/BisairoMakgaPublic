
![header](https://capsule-render.vercel.app/api?type=Waving&color=auto&height=150&section=header&text=BisairoMakga&fontSize=90)

> # _BisairoMakga_

평화롭고 한적한 마을, 비 내리는 날에도 굴하지 않는 당신은, 모든 비를 피하기로 마음먹었습니다!✨

*BisairoMakga*는 하늘에서 내리는 비를 피하는 게임입니다.🌧

여러분이 조종하는 캐릭터가 하늘에서 내리는 비를 피하기만 하면 되는 게임으로, 비를 맞으면 게임오버가 됩니다.💣💥

- - -
 # 목차
 - [개요](#개요)
 - [게임 설명](#게임-설명)
 - [게임 플레이 방식](#게임-플레이-방식)
 - [개발 과정 초반](#개발-과정-초반)
 - [개발 과정 중반](#개발-과정-중반)
 - [개발 과정 후반](#개발-과정-후반)
- - -
 # 개요
- 프로젝트 이름 :  *BisairoMakga*💧
- 프로젝트 지속기간 : 2024.05.16 - 2024.05.22
- 개발 엔진 및 언어 : Unity & C#
- 팀 이름 : 연 매출 8조💎
- 멤버 : 손민욱,배성철,강채린,권지민🙆‍♂
- - -
# 게임 설명

|![비사이로막가 시작화면](https://github.com/peterbae9327/BisairoMakga/assets/167067342/d47cf18d-83a2-41ef-b9c1-7d7ec8aa2c63)|![비사이로막가 메인화면](https://github.com/peterbae9327/BisairoMakga/assets/167067342/ad02e973-f7df-475e-9cde-ba8e0f857733)|
|:---:|:---:|
|시작 화면|메인 화면|

- ### 비를 피해라!💦
  - BisairoMakga는 하늘에서 떨어지는 비를 피하는 게임입니다.   
    플레이어는 주어진 캐릭터를 이용하여 떨어지는 비를 피하기만 하면 되는 게임입니다.   
    플레이어가 비를 피할수록 점수를 얻게 됩니다.   
    점수는 비가 플레이어가 아닌 땅에 떨어질 시에 1점, 살아남는 시간 1초당 1점입니다.
- - -
 # 게임 플레이 방식
 
 ### 캐릭터 이동 방법🎮
 
|**이동방향**|**좌(왼쪽)**|**우(오른쪽)**|
|:------:|:---:|:---:|
|방향키|⬅️|➡️|

- 간단합니다. 좌우로 비를 피하기만 하면 되니까요.
- - -

# 개발 과정 초반

### 와이어프레임

![1주차 와이어프레임](https://github.com/peterbae9327/BisairoMakga/assets/167067342/07a31e74-4bc4-406a-8080-eb99f31e52f1)

   - 게임 개발에 들어가기 전, 구현할 기능들을 정리해놓은 와이어 프레임입니다.    
  크게 4가지로 기능을 나눠 팀원들이 각자 하나씩 맡는 것으로 정했습니다.   
  각자 맡은 기능들입니다.
  
|**손민욱**|**배성철**|**강채린**|**권지민**| 
|:------:|:---:|:---:|:---:| 
|시작,종료 씬|비 오브젝트|캐릭터 오브젝트|메인 씬,UI|    

이 외의 추가 구현 및 잡다한 기능들은 각자 추가로 하고싶은 기능들을 구현하였습니다.

- - -


### 에셋

![개발과정 초반](https://github.com/peterbae9327/BisairoMakga/assets/167067342/a8156d40-fe9a-445d-871e-6ebb990bda88)
  - 메인씬을 처음 구성했을때입니다.   
    바닥과 캐릭터, 뒷 배경과 점수를 표시할 상단의 표도 만들어져 있습니다.   
    에셋이 없을때 간단하게 구성만 해놓은 모습입니다.

![비사이로막가 메인화면](https://github.com/peterbae9327/BisairoMakga/assets/167067342/ad02e973-f7df-475e-9cde-ba8e0f857733)

  - 에셋을 다운 받은 후 구성대로 설정한 메인씬입니다.   
    확실히 에셋이 있으니 어떤 게임인지가 명확해진 느낌입니다.
- - -
# 개발 과정 중반

- 캐릭터가 피해야할 비 를 만듭니다.   
그리고 그 캐릭터가 피할수 있도록 방향키로 움직일수 있게 만듭니다.   
비를 맞으면 엔드 씬으로 가도록 해줍니다.


![개발-중반](https://github.com/peterbae9327/BisairoMakga/assets/167067342/fb49e1d5-e6cc-44b9-8cbc-510aef0b32e3)

- - -
# 개발 과정 후반

- 엔드 씬에서 여러가지 선택지를 줍니다.   
  최종 점수와 최고 점수를 보여주고,
  버튼을 누르면 다시 시작할수 있게 해줍니다.


![개발-후반](https://github.com/peterbae9327/BisairoMakga/assets/167067342/dfae4f6d-0fe3-4f09-b538-5fd4ab697523)
- - -

    