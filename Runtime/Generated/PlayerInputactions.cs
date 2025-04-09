﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by NisGab's code generation tooling
//     from Assets/Config/InputSystemActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using UnityEngine.InputSystem;

namespace NisGab
{
	/// <summary>
	/// Simple event container for Player actions
	/// </summary>
	public class PlayerInputActions
	{
		public event Action<InputAction.CallbackContext> Move;
		public event Action<InputAction.CallbackContext> Look;
		public event Action<InputAction.CallbackContext> Attack;
		public event Action<InputAction.CallbackContext> Interact;
		public event Action<InputAction.CallbackContext> Crouch;
		public event Action<InputAction.CallbackContext> Jump;
		public event Action<InputAction.CallbackContext> Previous;
		public event Action<InputAction.CallbackContext> Next;
		public event Action<InputAction.CallbackContext> Sprint;

		internal void Bind(InputSystemActions.PlayerActions actions)
		{
			actions.Move.performed += OnMove;
			actions.Look.performed += OnLook;
			actions.Attack.performed += OnAttack;
			actions.Interact.performed += OnInteract;
			actions.Crouch.performed += OnCrouch;
			actions.Jump.performed += OnJump;
			actions.Previous.performed += OnPrevious;
			actions.Next.performed += OnNext;
			actions.Sprint.performed += OnSprint;
		}

		internal void UnBind(InputSystemActions.PlayerActions actions)
		{
			actions.Move.performed -= OnMove;
			actions.Look.performed -= OnLook;
			actions.Attack.performed -= OnAttack;
			actions.Interact.performed -= OnInteract;
			actions.Crouch.performed -= OnCrouch;
			actions.Jump.performed -= OnJump;
			actions.Previous.performed -= OnPrevious;
			actions.Next.performed -= OnNext;
			actions.Sprint.performed -= OnSprint;
		}

		private void OnMove(InputAction.CallbackContext context)
		{
			Move?.Invoke(context);
		}

		private void OnLook(InputAction.CallbackContext context)
		{
			Look?.Invoke(context);
		}

		private void OnAttack(InputAction.CallbackContext context)
		{
			Attack?.Invoke(context);
		}

		private void OnInteract(InputAction.CallbackContext context)
		{
			Interact?.Invoke(context);
		}

		private void OnCrouch(InputAction.CallbackContext context)
		{
			Crouch?.Invoke(context);
		}

		private void OnJump(InputAction.CallbackContext context)
		{
			Jump?.Invoke(context);
		}

		private void OnPrevious(InputAction.CallbackContext context)
		{
			Previous?.Invoke(context);
		}

		private void OnNext(InputAction.CallbackContext context)
		{
			Next?.Invoke(context);
		}

		private void OnSprint(InputAction.CallbackContext context)
		{
			Sprint?.Invoke(context);
		}
	}
}