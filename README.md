# NonstopKnight
![21241](https://github.com/user-attachments/assets/85a20cec-13fa-49be-b949-272d3228ee92)

팀스파르타 내일배움캠프 Unity 11기

3D 방치형 RPG 구현하기

## 주요 기능
### FSM(유한 상태 기계)

<img width="488" height="1085" alt="image" src="https://github.com/user-attachments/assets/0b8f3228-6b1e-45a4-ae5c-f906c1161579" />

<img width="548" height="610" alt="image" src="https://github.com/user-attachments/assets/60c8f4f4-8e23-425e-abc2-8389728f94ca" />

플레이어의 행동 로직을 FSM으로 구현

플레이어의 상태는 Idle, Chasing, Attack 상태로 구성되어 있으며

각각 공격, 추격, 공격의 행동을 한다.

### Scriptable Object

<img width="141" height="245" alt="image" src="https://github.com/user-attachments/assets/f61818d8-3e52-49cf-a37d-722cc20bfcd4" />

<img width="566" height="292" alt="image" src="https://github.com/user-attachments/assets/f6e92c55-404e-4aea-9920-6617e1e786d4" />

여러 데이터들을 Scriptable Object를 활용하여 작성하였다.

이 Scriptable Object 데이터를 통해 플레이어, 상점, 적 정보를 구성하는데 활용하였다.
