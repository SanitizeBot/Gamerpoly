using Assets.Scripts.Domain;
using Assets.Scripts.Utils;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;

namespace Assets.Scripts.Domain {
    public class Player {

        public string Name { get; private set; }
        public GameObject Token { get; private set; }
		public int Tile { get; set; }

        public Player(string _name, TokenFactory.Tokens _tok) {
            Name = _name;
            Token = TokenFactory.Get(_tok);
			Tile = 0;
        }

		public void Move (int pos) {
			Token.transform.position = GameSystem.Instance.Tiles [Tile = (Tile + pos) % 40].Position;
			Debug.Log("Moviendo "+Name+ " a "+ Tile);
		}
    
	}
}