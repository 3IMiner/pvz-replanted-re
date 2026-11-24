# System.Void UpdateAbilities()

- 类：`Plant`
- 汇编行数：2717

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,80h
	cmp byte ptr [184EEB645h],0
	mov rbx,rcx
	jne short 00000001806B61A4h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB645h],1
	cmp qword ptr [rbx+18h],0
	je near ptr 00000001806B632Ch
	cmp byte ptr [rbx+137h],0
	je near ptr 00000001806B632Ch
	mov [rsp+90h],rbp
	mov [rsp+98h],rsi
	mov [rsp+0A0h],rdi
	movaps [rsp+70h],xmm6
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,2Bh
	je near ptr 00000001806B630Fh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor edx,edx
	call 00000001807E3010h
	cmp eax,32h
	je near ptr 00000001806B630Fh
	cmp dword ptr [rbx+88h],2
	je short 00000001806B6222h
	cmp byte ptr [rbx+3Ch],0
	je short 00000001806B622Fh
	sub dword ptr [rbx+98h],1
	js near ptr 00000001806B7A9Eh
	cmp dword ptr [rbx+124h],0
	jle short 00000001806B6292h
	mov eax,[rbx+124h]
	dec eax
	mov [rbx+124h],eax
	cmp eax,3Ch
	jne short 00000001806B627Ch
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,53h
	call 0000000180002040h
	cmp dword ptr [rbx+124h],0
	jne short 00000001806B6292h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbx
	call 00000001806B5700h
	cmp byte ptr [rbx+136h],0
	jne short 00000001806B630Fh
	cmp byte ptr [rbx+3Ch],0
	jne short 00000001806B630Fh
	cmp dword ptr [rbx+128h],0
	jne short 00000001806B630Fh
	xor edx,edx
	mov rcx,rbx
	call 00000001806BC710h
	cmp dword ptr [rbx+0A0h],0
	jle short 00000001806B62C3h
	dec dword ptr [rbx+0A0h]
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B62DCh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806B6335h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor edx,edx
	call 00000001807DFA20h
	test al,al
	je short 00000001806B6335h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B7D50h
	mov rdi,[rsp+0A0h]
	mov rsi,[rsp+98h]
	mov rbp,[rsp+90h]
	movaps xmm6,[rsp+70h]
	add rsp,80h
	pop rbx
	ret
	cmp dword ptr [rbx+70h],11h
	je near ptr 00000001806B7A58h
	cmp dword ptr [rbx+70h],0Fh
	je near ptr 00000001806B78FBh
	cmp dword ptr [rbx+70h],0Eh
	je near ptr 00000001806B78C8h
	cmp dword ptr [rbx+70h],6
	je near ptr 00000001806B74F7h
	cmp dword ptr [rbx+70h],1Bh
	je near ptr 00000001806B7454h
	cmp dword ptr [rbx+70h],21h
	je near ptr 00000001806B742Dh
	cmp dword ptr [rbx+70h],10h
	je near ptr 00000001806B7412h
	cmp dword ptr [rbx+70h],30h
	je near ptr 00000001806B7250h
	cmp dword ptr [rbx+70h],23h
	je near ptr 00000001806B7212h
	cmp dword ptr [rbx+70h],25h
	je near ptr 00000001806B7179h
	cmp dword ptr [rbx+70h],2Fh
	je near ptr 00000001806B6EE6h
	cmp dword ptr [rbx+70h],1Ah
	je near ptr 00000001806B6ED7h
	cmp dword ptr [rbx+70h],1Fh
	je near ptr 00000001806B6EC8h
	cmp dword ptr [rbx+70h],2Dh
	je near ptr 00000001806B6EB9h
	cmp dword ptr [rbx+70h],9
	je near ptr 00000001806B6CD1h
	cmp dword ptr [rbx+70h],1
	je near ptr 00000001806B6EAAh
	cmp dword ptr [rbx+70h],29h
	je near ptr 00000001806B6EAAh
	cmp dword ptr [rbx+70h],26h
	je near ptr 00000001806B6EAAh
	cmp dword ptr [rbx+70h],0Bh
	je near ptr 00000001806B6A8Ah
	cmp dword ptr [rbx+70h],16h
	je near ptr 00000001806B6908h
	cmp dword ptr [rbx+70h],4
	je near ptr 00000001806B653Bh
	cmp dword ptr [rbx+70h],15h
	je short 00000001806B6441h
	cmp dword ptr [rbx+70h],2Eh
	je short 00000001806B6441h
	cmp dword ptr [rbx+70h],13h
	je short 00000001806B6432h
	cmp dword ptr [rbx+70h],0Dh
	jne near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BBEF0h
	jmp near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BDC80h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB664h],0
	jne short 00000001806B645Dh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB664h],1
	cmp dword ptr [rbx+88h],12h
	je short 00000001806B648Fh
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B5B90h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	je short 00000001806B64D1h
	cmp dword ptr [rbx+70h],2Eh
	mov eax,[rbx+0A0h]
	je short 00000001806B64ABh
	cmp eax,4Bh
	je short 00000001806B64B9h
	jmp short 00000001806B64D9h
	cmp eax,46h
	je short 00000001806B64B9h
	cmp dword ptr [rbx+0A0h],20h
	jne short 00000001806B64D9h
	xor r9d,r9d
	mov edx,14h
	mov r8d,21h
	mov rcx,rbx
	call 00000001806AD520h
	jmp short 00000001806B64D9h
	xor esi,esi
	mov [rbx+88h],esi
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B6510h
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DB4h]
	call 00000001806CBD40h
	xor r8d,r8d
	movaps xmm1,xmm0
	mov rcx,rbx
	call 00000001806B4C50h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB65Ch],0
	jne short 00000001806B6593h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C97ED8h]
	call 00000001804FEB70h
	lea rcx,[184C94FA0h]
	call 00000001804FEB70h
	lea rcx,[184C96FA8h]
	call 00000001804FEB70h
	lea rcx,[184C92EB8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Ch],1
	cmp dword ptr [rbx+88h],0
	je near ptr 00000001806B683Eh
	cmp dword ptr [rbx+88h],0Fh
	je near ptr 00000001806B6656h
	cmp dword ptr [rbx+88h],10h
	jne near ptr 00000001806B7A62h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	jne near ptr 00000001806B74E8h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov edx,[rbx+0F4h]
	xor r8d,r8d
	call 00000001807E1430h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806AD0C0h
	mov rcx,[184C2AFC0h]
	mov ebp,eax
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B661Ch
	call 00000001804FEEB0h
	xor esi,esi
	mov r9d,0Ah
	mov [rsp+30h],rsi
	mov r8d,ebp
	mov dword ptr [rsp+28h],1
	mov edx,32h
	mov ecx,0C8h
	mov dword ptr [rsp+20h],3
	call 00000001806CC120h
	mov [rdi+80h],eax
	jmp near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B668Dh
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DB4h]
	call 00000001806CBD40h
	cmp byte ptr [184EEB658h],0
	movaps xmm6,xmm0
	mov rdi,[184C92EB8h]
	jne short 00000001806B66D7h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B7AADh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor esi,esi
	movaps xmm3,xmm6
	mov [rsp+28h],rsi
	xor r8d,r8d
	mov rdx,rax
	mov [rsp+20h],esi
	call 00000001807C8270h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov edx,[rbx+70h]
	xor r8d,r8d
	call 00000001807DD8A0h
	test rax,rax
	je near ptr 00000001806B7AADh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov r9d,[rbx+38h]
	xorps xmm2,xmm2
	mov eax,[rax+40h]
	add r9d,2
	mov [rsp+28h],rsi
	xorps xmm1,xmm1
	mov [rsp+20h],eax
	call 00000001807D96D0h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	mov rcx,rax
	call 00000001806CAF80h
	subss xmm6,dword ptr [183C33D94h]
	xor r8d,r8d
	mov rcx,rdi
	movaps xmm1,xmm6
	call 00000001806CAEE0h
	mov rdx,[184C94FA0h]
	xor r8d,r8d
	mov rcx,rdi
	call 00000001806CAC10h
	mov dword ptr [rdi+80h],0Ah
	xor r8d,r8d
	mov rdx,[184C94FA0h]
	mov rcx,rdi
	call 000000018060F880h
	mov rdx,[184C94FA0h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rdi
	call 000000018060F880h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	mov rdx,rdi
	call 00000001807E13A0h
	mov rdx,[rbx+140h]
	xor r9d,r9d
	mov [rbx+0F4h],eax
	mov rcx,rdi
	mov r8,[184C96FA8h]
	call 000000018060F880h
	xor edx,edx
	mov dword ptr [rbx+88h],10h
	mov ecx,190h
	call 00000001806CBE80h
	add eax,190h
	mov [rbx+0FCh],eax
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movd xmm2,dword ptr [rbx+2Ch]
	xor esi,esi
	movd xmm1,dword ptr [rbx+28h]
	mov r9d,[rbx+38h]
	cvtdq2ps xmm2,xmm2
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],31h
	cvtdq2ps xmm1,xmm1
	mulss xmm2,dword ptr [183C33C40h]
	mulss xmm1,dword ptr [183C33C40h]
	addss xmm2,dword ptr [rbx+24h]
	addss xmm1,dword ptr [rbx+20h]
	call 00000001807D9B50h
	movss xmm0,dword ptr [183C33EE4h]
	mov r9d,14h
	mov rdx,[184C97ED8h]
	mov r8d,3
	mov [rsp+28h],rsi
	mov rcx,rbx
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov r8,[rbx+10h]
	mov dword ptr [rbx+88h],0Fh
	test r8,r8
	je near ptr 00000001806B7AADh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,50h
	call 0000000180002040h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB652h],0
	jne short 00000001806B693Ch
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C7FBD8h]
	call 00000001804FEB70h
	lea rcx,[184C7FCB0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB652h],1
	xorps xmm0,xmm0
	lea rcx,[rsp+60h]
	xorps xmm1,xmm1
	xor r9d,r9d
	xor r8d,r8d
	mov rdx,rbx
	movups [rsp+50h],xmm0
	movups [rsp+40h],xmm1
	call 00000001806B1660h
	xor esi,esi
	mov edx,esi
	movups xmm0,[rax]
	mov rax,[rbx+18h]
	movups [rsp+50h],xmm0
	test rax,rax
	je near ptr 00000001806B7AB3h
	nop dword ptr [rax+rax]
	mov rcx,[rax+80h]
	test rcx,rcx
	je near ptr 00000001806B7AB3h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806B7A62h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B7AB3h
	mov rcx,[rax+80h]
	test rcx,rcx
	je near ptr 00000001806B7AB3h
	mov r8,[184C7FCB0h]
	mov edx,esi
	call 0000000182449330h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806B7AB3h
	mov ecx,[rbx+34h]
	cmp [rax+34h],ecx
	jne near ptr 00000001806B6A74h
	cmp dword ptr [rax+0A8h],0
	je short 00000001806B69F7h
	cmp dword ptr [rax+0A8h],0Eh
	je short 00000001806B69F7h
	cmp dword ptr [rax+0A8h],1
	jne short 00000001806B6A74h
	xor r8d,r8d
	lea rcx,[rsp+60h]
	mov rdx,rdi
	call 00000001806C86F0h
	mov rcx,[184C2AFC0h]
	movups xmm0,[rax]
	movups [rsp+40h],xmm0
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B6A24h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+40h]
	lea rcx,[rsp+50h]
	call 00000001806CBAA0h
	cmp eax,0Ah
	jl short 00000001806B6A74h
	cmp dword ptr [rdi+0A8h],0
	je short 00000001806B6A66h
	cmp dword ptr [rdi+0A8h],0Eh
	je short 00000001806B6A66h
	cmp dword ptr [rdi+0A8h],1
	jne short 00000001806B6A74h
	mov edx,[rbx+74h]
	xor r8d,r8d
	mov rcx,rdi
	call 00000001806C71E0h
	jmp short 00000001806B6A74h
	mov edx,[rbx+74h]
	xor r8d,r8d
	mov rcx,rdi
	call 00000001806C6F60h
	mov rax,[rbx+18h]
	inc esi
	mov edx,esi
	test rax,rax
	je near ptr 00000001806B7AB3h
	jmp near ptr 00000001806B6980h
	cmp byte ptr [184EEB64Eh],0
	jne short 00000001806B6AA6h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Eh],1
	cmp dword ptr [rbx+88h],8
	je near ptr 00000001806B6BBAh
	cmp dword ptr [rbx+88h],9
	jne near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor edx,edx
	call 00000001807DF9F0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	test al,al
	jne short 00000001806B6B25h
	call 000000018065DEF0h
	test rax,rax
	je short 00000001806B6B39h
	xor edx,edx
	mov rcx,rax
	call 00000001806C2390h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	inc dword ptr [rcx+2F4h]
	jmp short 00000001806B6B39h
	call 000000018065F400h
	test rax,rax
	je short 00000001806B6B39h
	xor edx,edx
	mov rcx,rax
	call 00000001806EBF90h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm2,dword ptr [rbx+24h]
	xor esi,esi
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,[rbx+38h]
	movss xmm6,dword ptr [183C33DC4h]
	add r9d,4
	addss xmm2,dword ptr [183C33DCCh]
	addss xmm1,xmm6
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],19h
	call 00000001807D9B50h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,0Ch
	movss xmm2,dword ptr [rbx+24h]
	addss xmm1,xmm6
	mov [rsp+20h],rsi
	call 000000018065C570h
	jmp near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C95FA8h]
	jne short 00000001806B6C0Bh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B7AADh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33DB4h]
	xor esi,esi
	mov [rsp+28h],rsi
	xor r8d,r8d
	mov rdx,rdi
	mov [rsp+20h],esi
	call 00000001807C8270h
	movss xmm2,dword ptr [rbx+24h]
	mov rcx,rbx
	movss xmm1,dword ptr [rbx+20h]
	mov r9d,[rbx+38h]
	addss xmm2,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33DC4h]
	add r9d,4
	mov [rsp+28h],rsi
	mov dword ptr [rbx+0A0h],190h
	mov dword ptr [rbx+88h],9
	mov dword ptr [rsp+20h],18h
	call 00000001806AB220h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB666h],0
	jne short 00000001806B6D11h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C95150h]
	call 00000001804FEB70h
	lea rcx,[184C93218h]
	call 00000001804FEB70h
	mov byte ptr [184EEB666h],1
	cmp dword ptr [rbx+88h],17h
	je near ptr 00000001806B6DB9h
	cmp dword ptr [rbx+88h],18h
	je short 00000001806B6D36h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BACD0h
	jmp near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B6D6Dh
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DB4h]
	call 00000001806CBD40h
	mov rdx,[184C93218h]
	xor esi,esi
	mov [rsp+28h],rsi
	mov r9d,0Ah
	xor r8d,r8d
	movss dword ptr [rsp+20h],xmm0
	mov rcx,rbx
	call 00000001806B4B80h
	mov dword ptr [rbx+88h],19h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B6EAAh
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C95150h]
	jne short 00000001806B6DF5h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B7AADh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33DB4h]
	xor esi,esi
	mov [rsp+28h],rsi
	xor r8d,r8d
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rbx+10h]
	mov dword ptr [rbx+88h],18h
	test r8,r8
	je near ptr 00000001806B7AADh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,3Fh
	call 0000000180002040h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BACD0h
	jmp near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B9030h
	jmp near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B9BC0h
	jmp near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B84A0h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB66Eh],0
	jne short 00000001806B6F1Ah
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C93800h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Eh],1
	cmp dword ptr [rbx+88h],23h
	je near ptr 00000001806B70B4h
	cmp dword ptr [rbx+88h],24h
	je near ptr 00000001806B7018h
	cmp dword ptr [rbx+88h],25h
	je short 00000001806B6FABh
	cmp dword ptr [rbx+88h],26h
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33F94h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	test al,al
	je near ptr 00000001806B7A62h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,4Ch
	call 0000000180002040h
	jmp near ptr 00000001806B7A62h
	mov rax,[rbx+18h]
	mov rdi,[rbx+140h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov rcx,[184C2AFC0h]
	mov esi,[rax+1ECh]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B6FDAh
	call 00000001804FEEB0h
	xor r9d,r9d
	lea rcx,[rsp+60h]
	mov r8d,4Bh
	mov edx,esi
	call 00000001806CB9C0h
	test rdi,rdi
	je near ptr 00000001806B7AADh
	movups xmm0,[rax]
	xor r9d,r9d
	lea rdx,[rsp+50h]
	xor r8d,r8d
	mov rcx,rdi
	movaps [rsp+50h],xmm0
	call 000000018060F880h
	jmp near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33C40h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	test al,al
	je short 00000001806B7070h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,40h
	call 0000000180002040h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	movss xmm1,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov rcx,rbx
	mov dword ptr [rbx+88h],25h
	call 00000001806B4C50h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],24h
	mov rdi,[184C93800h]
	jne short 00000001806B70FAh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B7AADh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33DB4h]
	xor esi,esi
	mov [rsp+28h],rsi
	xor r8d,r8d
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+88h],28h
	je short 00000001806B71DEh
	cmp dword ptr [rbx+88h],29h
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	movss xmm1,dword ptr [183C33DACh]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B4C50h
	xor esi,esi
	xor edx,edx
	mov rcx,rbx
	mov [rbx+88h],esi
	call 00000001806AC2A0h
	mov [rbx+38h],eax
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	mov edx,[rbx+34h]
	xor r9d,r9d
	inc edx
	xor r8d,r8d
	mov ecx,4A768h
	call 0000000180665070h
	mov [rbx+38h],eax
	mov dword ptr [rbx+88h],29h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+88h],2
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB675h],0
	jne short 00000001806B726Ch
	lea rcx,[184C949B8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB675h],1
	cmp dword ptr [rbx+88h],2Ah
	jne near ptr 00000001806B7373h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33EBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8910h
	xor esi,esi
	test al,al
	je short 00000001806B72E1h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,61A80h
	movss xmm1,dword ptr [rbx+20h]
	addss xmm2,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33DC4h]
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],47h
	call 00000001807D9B50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov r9d,[rbx+12Ch]
	mov r8d,[rbx+34h]
	mov edx,[rbx+74h]
	mov [rsp+38h],rsi
	mov [rsp+30h],sil
	mov [rsp+28h],sil
	mov dword ptr [rsp+20h],30h
	call 00000001806553E0h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806B7AADh
	mov rcx,[rax+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor edx,edx
	call 00000001807B6EF0h
	mov byte ptr [rdi+139h],1
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],2Ah
	mov rdi,[184C949B8h]
	jne short 00000001806B73B9h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806B7AADh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33FB0h]
	xor esi,esi
	mov [rsp+28h],rsi
	xor r8d,r8d
	mov rdx,rax
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+88h],30h
	jne near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	je short 00000001806B7447h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+88h],2Fh
	jne near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	xor esi,esi
	mov [rbx+88h],esi
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB669h],0
	jne short 00000001806B7470h
	lea rcx,[184C2A910h]
	call 00000001804FEB70h
	mov byte ptr [184EEB669h],1
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle short 00000001806B74CEh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C76C0h
	test eax,eax
	je short 00000001806B74CEh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov rdx,[184C2A910h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	cmp dword ptr [rbx+88h],2
	je near ptr 00000001806B7A62h
	cmp dword ptr [rbx+9Ch],0
	jne near ptr 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806AD780h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB655h],0
	jne short 00000001806B7537h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C932A8h]
	call 00000001804FEB70h
	lea rcx,[184C39168h]
	call 00000001804FEB70h
	lea rcx,[184CADDD0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB655h],1
	cmp dword ptr [rbx+88h],1
	je near ptr 00000001806B781Ch
	cmp dword ptr [rbx+88h],0Ah
	je near ptr 00000001806B76D5h
	cmp dword ptr [rbx+88h],0Bh
	je near ptr 00000001806B7636h
	cmp dword ptr [rbx+88h],0Dh
	je short 00000001806B75C1h
	cmp dword ptr [rbx+88h],0Eh
	je short 00000001806B757Dh
	cmp dword ptr [rbx+88h],0Ch
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	movss xmm1,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B4C50h
	mov dword ptr [rbx+88h],1
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33DB4h]
	xor esi,esi
	mov rdx,[184C932A8h]
	xor r8d,r8d
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+88h],0Eh
	jmp near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33DB8h]
	xor esi,esi
	mov rdx,[184C39168h]
	xor r8d,r8d
	mov [rsp+20h],rsi
	call 00000001807C8210h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je short 00000001806B76BCh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	mov dword ptr [rbx+88h],0Dh
	mov dword ptr [rbx+0A0h],0FA0h
	jmp near ptr 00000001806B7A62h
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806B7A62h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,3Dh
	call 0000000180002040h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	xor bpl,bpl
	mov rdi,rax
	test rax,rax
	je short 00000001806B7749h
	cmp dword ptr [rax+70h],17h
	je short 00000001806B7741h
	cmp dword ptr [rax+70h],20h
	je short 00000001806B7741h
	cmp dword ptr [rax+70h],19h
	jne short 00000001806B7749h
	mov bpl,1
	xor sil,sil
	jmp short 00000001806B7751h
	xor sil,sil
	test rdi,rdi
	je short 00000001806B7779h
	xor edx,edx
	mov rcx,rdi
	call 00000001806F3670h
	test al,al
	jne short 00000001806B777Ch
	xor edx,edx
	mov rcx,rdi
	call 00000001806F35E0h
	test al,al
	jne short 00000001806B7779h
	cmp dword ptr [rdi+74h],0Ch
	je short 00000001806B7779h
	cmp dword ptr [rdi+74h],0Bh
	jne short 00000001806B777Ch
	mov sil,1
	test bpl,bpl
	jne short 00000001806B77C0h
	test sil,sil
	jne near ptr 00000001806B780Dh
	test rdi,rdi
	je near ptr 00000001806B7AADh
	xor edx,edx
	mov rcx,rdi
	call 00000001806EC320h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov [rax+239h],sil
	mov dword ptr [rbx+88h],0Bh
	jmp near ptr 00000001806B7A62h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806B7AADh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,1
	call 0000000180002040h
	test rdi,rdi
	je near ptr 00000001806B7AADh
	xor r9d,r9d
	xor r8d,r8d
	mov edx,28h
	mov rcx,rdi
	call 00000001806F8F60h
	mov dword ptr [rbx+88h],0Ch
	jmp near ptr 00000001806B7A62h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	xor r9d,r9d
	xor r8d,r8d
	mov edx,3
	call 00000001807C8640h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33EF0h]
	xor esi,esi
	mov rdx,[184CADDD0h]
	xor r8d,r8d
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov dword ptr [rbx+88h],0Ah
	mov dword ptr [rbx+0A0h],46h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [rbx+136h],0
	jne near ptr 00000001806B7A62h
	cmp dword ptr [rbx+88h],2
	je near ptr 00000001806B7A62h
	mov dword ptr [rbx+88h],2
	mov dword ptr [rbx+9Ch],64h
	jmp near ptr 00000001806B7A62h
	cmp byte ptr [184EEB65Bh],0
	jne short 00000001806B7947h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C8DF20h]
	call 00000001804FEB70h
	lea rcx,[184C70610h]
	call 00000001804FEB70h
	lea rcx,[184C8DD70h]
	call 00000001804FEB70h
	lea rcx,[184C8DE48h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Bh],1
	cmp byte ptr [rbx+136h],0
	jne near ptr 00000001806B7A62h
	cmp dword ptr [rbx+88h],2
	je near ptr 00000001806B7A62h
	mov rcx,[rbx+140h]
	mov dword ptr [rbx+88h],2
	mov dword ptr [rbx+9Ch],64h
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm3,dword ptr [183C33EECh]
	xor esi,esi
	mov rdx,[184C70610h]
	xor r8d,r8d
	mov [rsp+28h],rsi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm2,dword ptr [183C33C4Ch]
	xor r9d,r9d
	mov rdx,[184C8DD70h]
	mov [rsp+20h],rsi
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	movss xmm6,dword ptr [183C33D94h]
	xor r9d,r9d
	mov rdx,[184C8DE48h]
	movaps xmm2,xmm6
	mov [rsp+20h],rsi
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806B7AADh
	mov rdx,[184C8DF20h]
	xor r9d,r9d
	movaps xmm2,xmm6
	mov [rsp+20h],rsi
	call 000000018060F880h
	mov r8,[rbx+10h]
	test r8,r8
	je short 00000001806B7AADh
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806B7AADh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,39h
	call 0000000180002040h
	jmp short 00000001806B7A62h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BD300h
	cmp dword ptr [rbx+94h],1
	jne short 00000001806B7A75h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BC420h
	cmp dword ptr [rbx+9Ch],0
	jle near ptr 00000001806B630Fh
	sub dword ptr [rbx+9Ch],1
	jne near ptr 00000001806B630Fh
	xor edx,edx
	mov rcx,rbx
	call 00000001806AD780h
	jmp near ptr 00000001806B630Fh
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	jmp near ptr 00000001806B630Fh
	call 00000001804FEE20h
	int 3
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -128
	004 Compare [0x184EEB645], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C2D478]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB645], 1
	012 Compare [rbx+24], 0
	013 JumpIfEqual {100}
	014 Compare [rbx+311], 0
	015 JumpIfEqual {100}
	016 Move stack:0x90, rbp
	017 Move stack:0x98, rsi
	018 Move stack:0xA0, rdi
	019 Move stack:0x70, xmm6
	020 Move rcx, [rbx+16]
	021 Compare rcx, 0
	022 JumpIfEqual {1355}
	023 Move rdx, 0
	024 Call GameplayActivity.get_GameMode, rcx, rdx
	025 Compare rax, 43
	026 JumpIfEqual {96}
	027 Move rcx, [rbx+16]
	028 Compare rcx, 0
	029 JumpIfEqual {1355}
	030 Move rdx, 0
	031 Call GameplayActivity.get_GameMode, rcx, rdx
	032 Compare rax, 50
	033 JumpIfEqual {96}
	034 Compare [rbx+136], 2
	035 JumpIfEqual {38}
	036 Compare [rbx+60], 0
	037 JumpIfEqual {40}
	038 Subtract [rbx+152], [rbx+152], 1
	039 JumpIfSign {1351}
	040 Compare [rbx+292], 0
	041 JumpIfLessOrEqual {63}
	042 Move rax, [rbx+292]
	043 Subtract rax, rax, 1
	044 Move [rbx+292], rax
	045 Compare rax, 60
	046 JumpIfNotEqual {57}
	047 Move rax, [rbx+16]
	048 Compare rax, 0
	049 JumpIfEqual {1355}
	050 Move r8, [rax+88]
	051 Compare r8, 0
	052 JumpIfEqual {1355}
	053 Move rdx, typeof(Reloaded.Services.IAudioService)
	054 Move rcx, 6
	055 Move r9, 83
	056 Call 0x180002040, rcx, rdx, r8, r9
	057 Compare [rbx+292], 0
	058 JumpIfNotEqual {63}
	059 Move r8, 0
	060 Move rdx, 0
	061 Move rcx, rbx
	062 Call Plant.SetSleeping, rcx, rdx
	063 Compare [rbx+310], 0
	064 JumpIfNotEqual {96}
	065 Compare [rbx+60], 0
	066 JumpIfNotEqual {96}
	067 Compare [rbx+296], 0
	068 JumpIfNotEqual {96}
	069 Move rdx, 0
	070 Move rcx, rbx
	071 Call Plant.UpdateShooting, rcx, rdx
	072 Compare [rbx+160], 0
	073 JumpIfLessOrEqual {75}
	074 Subtract [rbx+160], [rbx+160], 1
	075 Move rcx, typeof(UnityEngine.Object)
	076 Move rdi, [rbx+16]
	077 Compare [rcx+228], 0
	078 JumpIfNotEqual {80}
	079 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	080 Move r8, 0
	081 Move rdx, 0
	082 Move rcx, rdi
	083 Call Object.op_Inequality, rcx, rdx, r8
	084 Compare rax, 0
	085 JumpIfEqual {104}
	086 Move rcx, [rbx+16]
	087 Compare rcx, 0
	088 JumpIfEqual {1355}
	089 Move rdx, 0
	090 Call GameplayActivity.IsWallnutBowlingLevel, rcx, rdx
	091 Compare rax, 0
	092 JumpIfEqual {104}
	093 Move rdx, 0
	094 Move rcx, rbx
	095 Call Plant.UpdateBowling, rcx, rdx
	096 Move rdi, stack:0xA0
	097 Move rsi, stack:0x98
	098 Move rbp, stack:0x90
	099 Move xmm6, stack:0x70
	100 ShiftStack 128
	101 Move rbx, stack:0x0
	102 ShiftStack 8
	103 Return 
	104 Compare [rbx+112], 17
	105 JumpIfEqual {1335}
	106 Compare [rbx+112], 15
	107 JumpIfEqual {1270}
	108 Compare [rbx+112], 14
	109 JumpIfEqual {1263}
	110 Compare [rbx+112], 6
	111 JumpIfEqual {1055}
	112 Compare [rbx+112], 27
	113 JumpIfEqual {1019}
	114 Compare [rbx+112], 33
	115 JumpIfEqual {1012}
	116 Compare [rbx+112], 16
	117 JumpIfEqual {1007}
	118 Compare [rbx+112], 48
	119 JumpIfEqual {918}
	120 Compare [rbx+112], 35
	121 JumpIfEqual {904}
	122 Compare [rbx+112], 37
	123 JumpIfEqual {870}
	124 Compare [rbx+112], 47
	125 JumpIfEqual {739}
	126 Compare [rbx+112], 26
	127 JumpIfEqual {735}
	128 Compare [rbx+112], 31
	129 JumpIfEqual {731}
	130 Compare [rbx+112], 45
	131 JumpIfEqual {727}
	132 Compare [rbx+112], 9
	133 JumpIfEqual {632}
	134 Compare [rbx+112], 1
	135 JumpIfEqual {723}
	136 Compare [rbx+112], 41
	137 JumpIfEqual {723}
	138 Compare [rbx+112], 38
	139 JumpIfEqual {723}
	140 Compare [rbx+112], 11
	141 JumpIfEqual {510}
	142 Compare [rbx+112], 22
	143 JumpIfEqual {421}
	144 Compare [rbx+112], 4
	145 JumpIfEqual {221}
	146 Compare [rbx+112], 21
	147 JumpIfEqual {162}
	148 Compare [rbx+112], 46
	149 JumpIfEqual {162}
	150 Compare [rbx+112], 19
	151 JumpIfEqual {158}
	152 Compare [rbx+112], 13
	153 JumpIfNotEqual {1338}
	154 Move rdx, 0
	155 Move rcx, rbx
	156 Call Plant.UpdateScaredyShroom, rcx, rdx
	157 Goto {1338}
	158 Move rdx, 0
	159 Move rcx, rbx
	160 Call Plant.UpdateTanglekelp, rcx, rdx
	161 Goto {1338}
	162 Compare [0x184EEB664], 0
	163 JumpIfNotEqual {167}
	164 LoadAddress rcx, [0x184C2AFC0]
	165 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	166 Move [0x184EEB664], 1
	167 Compare [rbx+136], 18
	168 JumpIfEqual {180}
	169 Move rdx, [rbx+52]
	170 Move r9, 0
	171 Move r8, 0
	172 Move rcx, rbx
	173 Call Plant.FindTargetZombie, rcx, rdx, r8
	174 Compare rax, 0
	175 JumpIfEqual {1338}
	176 Move rdx, 0
	177 Move rcx, rbx
	178 Call Plant.SpikeweedAttack, rcx, rdx
	179 Goto {1338}
	180 Compare [rbx+160], 0
	181 JumpIfEqual {198}
	182 Compare [rbx+112], 46
	183 Move rax, [rbx+160]
	184 JumpIfEqual {188}
	185 Compare rax, 75
	186 JumpIfEqual {192}
	187 Goto {200}
	188 Compare rax, 70
	189 JumpIfEqual {192}
	190 Compare [rbx+160], 32
	191 JumpIfNotEqual {200}
	192 Move r9, 0
	193 Move rdx, 20
	194 Move r8, 33
	195 Move rcx, rbx
	196 Call Plant.DoRowAreaDamage, rcx, rdx, r8
	197 Goto {200}
	198 Move rsi, 0
	199 Move [rbx+136], rsi
	200 Move rcx, [rbx+320]
	201 Compare rcx, 0
	202 JumpIfEqual {1355}
	203 Move r8, 0
	204 Move rdx, 0
	205 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	206 Compare rax, 0
	207 JumpIfLessOrEqual {1338}
	208 Move rcx, typeof(Reloaded.Gameplay.Common)
	209 Compare [rcx+228], 0
	210 JumpIfNotEqual {212}
	211 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	212 Move xmm1, [0x183C33DB8]
	213 Move r8, 0
	214 Move xmm0, [0x183C33DB4]
	215 Call Common.RandRangeFloat, xmm0, xmm1, r8
	216 Move r8, 0
	217 Move xmm1, xmm0
	218 Move rcx, rbx
	219 Call Plant.PlayIdleAnim, rcx, rdx
	220 Goto {1338}
	221 Compare [0x184EEB65C], 0
	222 JumpIfNotEqual {236}
	223 LoadAddress rcx, [0x184C2AFC0]
	224 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	225 LoadAddress rcx, [0x184C75168]
	226 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	227 LoadAddress rcx, [0x184C97ED8]
	228 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	229 LoadAddress rcx, [0x184C94FA0]
	230 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	231 LoadAddress rcx, [0x184C96FA8]
	232 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	233 LoadAddress rcx, [0x184C92EB8]
	234 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	235 Move [0x184EEB65C], 1
	236 Compare [rbx+136], 0
	237 JumpIfEqual {383}
	238 Compare [rbx+136], 15
	239 JumpIfEqual {277}
	240 Compare [rbx+136], 16
	241 JumpIfNotEqual {1338}
	242 Move rdx, [rbx+52]
	243 Move r9, 0
	244 Move r8, 0
	245 Move rcx, rbx
	246 Call Plant.FindTargetZombie, rcx, rdx, r8
	247 Compare rax, 0
	248 JumpIfNotEqual {1051}
	249 Move rcx, [rbx+16]
	250 Compare rcx, 0
	251 JumpIfEqual {1355}
	252 Move rdx, [rbx+244]
	253 Move r8, 0
	254 Call GameplayActivity.ReanimationTryToGet, rcx, rdx
	255 Move rdi, rax
	256 Compare rax, 0
	257 JumpIfEqual {1338}
	258 Move rdx, 0
	259 Move rcx, rbx
	260 Call Plant.DistanceToClosestZombie, rcx, rdx
	261 Move rcx, typeof(Reloaded.Gameplay.Common)
	262 Move rbp, rax
	263 Compare [rcx+228], 0
	264 JumpIfNotEqual {266}
	265 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	266 Move rsi, 0
	267 Move r9, 10
	268 Move stack:0x30, rsi
	269 Move r8, rbp
	270 Move stack:0x28, 1
	271 Move rdx, 50
	272 Move rcx, 200
	273 Move stack:0x20, 3
	274 Call Common.TodAnimateCurve, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	275 Move [rdi+128], rax
	276 Goto {1338}
	277 Move rcx, [rbx+320]
	278 Compare rcx, 0
	279 JumpIfEqual {1355}
	280 Move r8, 0
	281 Move rdx, 0
	282 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	283 Compare rax, 0
	284 JumpIfLessOrEqual {1338}
	285 Move rcx, typeof(Reloaded.Gameplay.Common)
	286 Compare [rcx+228], 0
	287 JumpIfNotEqual {289}
	288 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	289 Move xmm1, [0x183C33DB8]
	290 Move r8, 0
	291 Move xmm0, [0x183C33DB4]
	292 Call Common.RandRangeFloat, xmm0, xmm1, r8
	293 Compare [0x184EEB658], 0
	294 Move xmm6, xmm0
	295 Move rdi, "anim_armed"
	296 JumpIfNotEqual {302}
	297 LoadAddress rcx, [0x184C92A80]
	298 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	299 LoadAddress rcx, [0x184C911F8]
	300 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	301 Move [0x184EEB658], 1
	302 Compare rdi, 0
	303 JumpIfEqual {1355}
	304 Move r8, ""
	305 Move r9, 0
	306 Move rdx, "anim_"
	307 Move rcx, rdi
	308 Call String.Replace, rcx, rdx, r8
	309 Move rcx, [rbx+320]
	310 Compare rcx, 0
	311 JumpIfEqual {1355}
	312 Move rsi, 0
	313 Move xmm3, xmm6
	314 Move stack:0x28, rsi
	315 Move r8, 0
	316 Move rdx, rax
	317 Move stack:0x20, rsi
	318 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	319 Move rcx, [rbx+16]
	320 Compare rcx, 0
	321 JumpIfEqual {1355}
	322 Move rdx, [rbx+112]
	323 Move r8, 0
	324 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	325 Compare rax, 0
	326 JumpIfEqual {1355}
	327 Move rcx, [rbx+16]
	328 Compare rcx, 0
	329 JumpIfEqual {1355}
	330 Move r9, [rbx+56]
	331 Move xmm2, 0
	332 Move rax, [rax+64]
	333 Add r9, r9, 2
	334 Move stack:0x28, rsi
	335 Move xmm1, 0
	336 Move stack:0x20, rax
	337 Call GameplayActivity.AddReanimation, rcx, xmm1, r8, r9, stack:0x0
	338 Move rdi, rax
	339 Compare rax, 0
	340 JumpIfEqual {1355}
	341 Move r8, 0
	342 Move rdx, 0
	343 Move rcx, rax
	344 Call Reanimation.set_mLoopType, rcx, rdx
	345 Subtract xmm6, xmm6, [0x183C33D94]
	346 Move r8, 0
	347 Move rcx, rdi
	348 Move xmm1, xmm6
	349 Call Reanimation.set_mAnimRate, rcx, rdx
	350 Move rdx, "anim_glow"
	351 Move r8, 0
	352 Move rcx, rdi
	353 Call Reanimation.SetFramesForLayer, rcx, rdx
	354 Move [rdi+128], 10
	355 Move r8, 0
	356 Move rdx, "anim_glow"
	357 Move rcx, rdi
	358 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	359 Move rdx, "anim_glow"
	360 Move r9, 0
	361 Move r8, 0
	362 Move rcx, rdi
	363 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	364 Move rcx, [rbx+16]
	365 Compare rcx, 0
	366 JumpIfEqual {1355}
	367 Move r8, 0
	368 Move rdx, rdi
	369 Call GameplayActivity.ReanimationGetID, rcx, rdx
	370 Move rdx, [rbx+320]
	371 Move r9, 0
	372 Move [rbx+244], rax
	373 Move rcx, rdi
	374 Move r8, "anim_light"
	375 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	376 Move rdx, 0
	377 Move [rbx+136], 16
	378 Move rcx, 400
	379 Call Common.Rand, rcx, rdx
	380 Add rax, rax, 400
	381 Move [rbx+252], rax
	382 Goto {1338}
	383 Compare [rbx+160], 0
	384 JumpIfNotEqual {1338}
	385 Move rcx, [rbx+16]
	386 Compare rcx, 0
	387 JumpIfEqual {1355}
	388 Move xmm2, [rbx+44]
	389 Move rsi, 0
	390 Move xmm1, [rbx+40]
	391 Move r9, [rbx+56]
	392 Move xmm2, xmm2
	393 Move stack:0x28, rsi
	394 Move stack:0x20, 49
	395 Move xmm1, xmm1
	396 Multiply xmm2, xmm2, [0x183C33C40]
	397 Multiply xmm1, xmm1, [0x183C33C40]
	398 Add xmm2, xmm2, [rbx+36]
	399 Add xmm1, xmm1, [rbx+32]
	400 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	401 Move xmm0, [0x183C33EE4]
	402 Move r9, 20
	403 Move rdx, "anim_rise"
	404 Move r8, 3
	405 Move stack:0x28, rsi
	406 Move rcx, rbx
	407 Move stack:0x20, xmm0
	408 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	409 Move r8, [rbx+16]
	410 Move [rbx+136], 15
	411 Compare r8, 0
	412 JumpIfEqual {1355}
	413 Move r8, [r8+88]
	414 Compare r8, 0
	415 JumpIfEqual {1355}
	416 Move rdx, typeof(Reloaded.Services.IAudioService)
	417 Move rcx, 6
	418 Move r9, 80
	419 Call 0x180002040, rcx, rdx, r8, r9
	420 Goto {1338}
	421 Compare [0x184EEB652], 0
	422 JumpIfNotEqual {430}
	423 LoadAddress rcx, [0x184C2AFC0]
	424 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	425 LoadAddress rcx, [0x184C7FBD8]
	426 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	427 LoadAddress rcx, [0x184C7FCB0]
	428 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	429 Move [0x184EEB652], 1
	430 Move xmm0, 0
	431 LoadAddress rcx, stack:0x60
	432 Move xmm1, 0
	433 Move r9, 0
	434 Move r8, 0
	435 Move rdx, rbx
	436 Move stack:0x50, xmm0
	437 Move stack:0x40, xmm1
	438 Call Plant.GetPlantAttackRect, rcx, rdx
	439 Move rsi, 0
	440 Move rdx, rsi
	441 Move xmm0, [rax]
	442 Move rax, [rbx+24]
	443 Move stack:0x50, xmm0
	444 Compare rax, 0
	445 JumpIfEqual {1357}
	446 Nop 
	447 Move rcx, [rax+128]
	448 Compare rcx, 0
	449 JumpIfEqual {1357}
	450 Compare rdx, [rcx+40]
	451 JumpIfGreaterOrEqual {1338}
	452 Move rax, [rbx+24]
	453 Compare rax, 0
	454 JumpIfEqual {1357}
	455 Move rcx, [rax+128]
	456 Compare rcx, 0
	457 JumpIfEqual {1357}
	458 Move r8, [0x184C7FCB0]
	459 Move rdx, rsi
	460 Call 0x182449330, rcx, rdx
	461 Move rdi, rax
	462 Compare rax, 0
	463 JumpIfEqual {1357}
	464 Move rcx, [rbx+52]
	465 Compare [rax+52], rcx
	466 JumpIfNotEqual {504}
	467 Compare [rax+168], 0
	468 JumpIfEqual {473}
	469 Compare [rax+168], 14
	470 JumpIfEqual {473}
	471 Compare [rax+168], 1
	472 JumpIfNotEqual {504}
	473 Move r8, 0
	474 LoadAddress rcx, stack:0x60
	475 Move rdx, rdi
	476 Call Projectile.GetProjectileRect, rcx, rdx
	477 Move rcx, typeof(Reloaded.Gameplay.Common)
	478 Move xmm0, [rax]
	479 Move stack:0x40, xmm0
	480 Compare [rcx+228], 0
	481 JumpIfNotEqual {483}
	482 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	483 Move r8, 0
	484 LoadAddress rdx, stack:0x40
	485 LoadAddress rcx, stack:0x50
	486 Call Common.GetRectOverlap, rcx, rdx, r8
	487 Compare rax, 10
	488 JumpIfLess {504}
	489 Compare [rdi+168], 0
	490 JumpIfEqual {500}
	491 Compare [rdi+168], 14
	492 JumpIfEqual {500}
	493 Compare [rdi+168], 1
	494 JumpIfNotEqual {504}
	495 Move rdx, [rbx+116]
	496 Move r8, 0
	497 Move rcx, rdi
	498 Call Projectile.ConvertToPea, rcx, rdx
	499 Goto {504}
	500 Move rdx, [rbx+116]
	501 Move r8, 0
	502 Move rcx, rdi
	503 Call Projectile.ConvertToFireball, rcx, rdx
	504 Move rax, [rbx+24]
	505 Add rsi, rsi, 1
	506 Move rdx, rsi
	507 Compare rax, 0
	508 JumpIfEqual {1357}
	509 Goto {447}
	510 Compare [0x184EEB64E], 0
	511 JumpIfNotEqual {515}
	512 LoadAddress rcx, [0x184C95FA8]
	513 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	514 Move [0x184EEB64E], 1
	515 Compare [rbx+136], 8
	516 JumpIfEqual {578}
	517 Compare [rbx+136], 9
	518 JumpIfNotEqual {1338}
	519 Compare [rbx+160], 0
	520 JumpIfNotEqual {1338}
	521 Move rcx, [rbx+16]
	522 Compare rcx, 0
	523 JumpIfEqual {1355}
	524 Move rdx, 0
	525 Call GameplayActivity.IsVersusMode, rcx, rdx
	526 Move rcx, [rbx+24]
	527 Compare rcx, 0
	528 JumpIfEqual {1355}
	529 Move r8, [rbx+52]
	530 Move r9, 0
	531 Move rdx, [rbx+116]
	532 Compare rax, 0
	533 JumpIfNotEqual {545}
	534 Call Board.GetGraveStoneAt, rcx, rdx, r8
	535 Compare rax, 0
	536 JumpIfEqual {551}
	537 Move rdx, 0
	538 Move rcx, rax
	539 Call GridItem.GridItemDie, rcx, rdx
	540 Move rcx, [rbx+24]
	541 Compare rcx, 0
	542 JumpIfEqual {1355}
	543 Add [rcx+756], [rcx+756], 1
	544 Goto {551}
	545 Call Board.GetVSGravestoneAt, rcx, rdx, r8
	546 Compare rax, 0
	547 JumpIfEqual {551}
	548 Move rdx, 0
	549 Move rcx, rax
	550 Call Zombie.DieNoLoot, rcx, rdx
	551 Move rcx, [rbx+16]
	552 Compare rcx, 0
	553 JumpIfEqual {1355}
	554 Move xmm2, [rbx+36]
	555 Move rsi, 0
	556 Move xmm1, [rbx+32]
	557 Move r9, [rbx+56]
	558 Move xmm6, [0x183C33DC4]
	559 Add r9, r9, 4
	560 Add xmm2, xmm2, [0x183C33DCC]
	561 Add xmm1, xmm1, xmm6
	562 Move stack:0x28, rsi
	563 Move stack:0x20, 25
	564 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	565 Move rdx, 0
	566 Move rcx, rbx
	567 Call Plant.Die, rcx, rdx
	568 Move rcx, [rbx+24]
	569 Compare rcx, 0
	570 JumpIfEqual {1355}
	571 Move xmm1, [rbx+32]
	572 Move r9, 12
	573 Move xmm2, [rbx+36]
	574 Add xmm1, xmm1, xmm6
	575 Move stack:0x20, rsi
	576 Call Board.DropLootPiece, rcx, xmm1, r8, r9
	577 Goto {1338}
	578 Move rcx, [rbx+320]
	579 Compare rcx, 0
	580 JumpIfEqual {1355}
	581 Move r8, 0
	582 Move rdx, 0
	583 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	584 Compare rax, 0
	585 JumpIfLessOrEqual {1338}
	586 Compare [0x184EEB658], 0
	587 Move rdi, "anim_idle"
	588 JumpIfNotEqual {594}
	589 LoadAddress rcx, [0x184C92A80]
	590 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	591 LoadAddress rcx, [0x184C911F8]
	592 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	593 Move [0x184EEB658], 1
	594 Compare rdi, 0
	595 JumpIfEqual {1355}
	596 Move r8, ""
	597 Move r9, 0
	598 Move rdx, "anim_"
	599 Move rcx, rdi
	600 Call String.Replace, rcx, rdx, r8
	601 Move rcx, [rbx+320]
	602 Move rdi, rax
	603 Compare rcx, 0
	604 JumpIfEqual {1355}
	605 Move xmm1, [0x183C33DAC]
	606 Move r9, 0
	607 Move r8, 0
	608 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	609 Move rcx, [rbx+320]
	610 Compare rcx, 0
	611 JumpIfEqual {1355}
	612 Move xmm3, [0x183C33DB4]
	613 Move rsi, 0
	614 Move stack:0x28, rsi
	615 Move r8, 0
	616 Move rdx, rdi
	617 Move stack:0x20, rsi
	618 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	619 Move xmm2, [rbx+36]
	620 Move rcx, rbx
	621 Move xmm1, [rbx+32]
	622 Move r9, [rbx+56]
	623 Add xmm2, xmm2, [0x183C33DC4]
	624 Add xmm1, xmm1, [0x183C33DC4]
	625 Add r9, r9, 4
	626 Move stack:0x28, rsi
	627 Move [rbx+160], 400
	628 Move [rbx+136], 9
	629 Move stack:0x20, 24
	630 Call Plant.AddAttachedParticle, rcx, xmm1, r8, r9, stack:0x0
	631 Goto {1338}
	632 Compare [0x184EEB666], 0
	633 JumpIfNotEqual {643}
	634 LoadAddress rcx, [0x184C2AFC0]
	635 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	636 LoadAddress rcx, [0x184C75168]
	637 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	638 LoadAddress rcx, [0x184C95150]
	639 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	640 LoadAddress rcx, [0x184C93218]
	641 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	642 Move [0x184EEB666], 1
	643 Compare [rbx+136], 23
	644 JumpIfEqual {677}
	645 Compare [rbx+136], 24
	646 JumpIfEqual {651}
	647 Move rdx, 0
	648 Move rcx, rbx
	649 Call Plant.UpdateProductionPlant, rcx, rdx
	650 Goto {1338}
	651 Move rcx, [rbx+320]
	652 Compare rcx, 0
	653 JumpIfEqual {1355}
	654 Move r8, 0
	655 Move rdx, 0
	656 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	657 Compare rax, 0
	658 JumpIfLessOrEqual {1338}
	659 Move rcx, typeof(Reloaded.Gameplay.Common)
	660 Compare [rcx+228], 0
	661 JumpIfNotEqual {663}
	662 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	663 Move xmm1, [0x183C33DB8]
	664 Move r8, 0
	665 Move xmm0, [0x183C33DB4]
	666 Call Common.RandRangeFloat, xmm0, xmm1, r8
	667 Move rdx, "anim_bigidle"
	668 Move rsi, 0
	669 Move stack:0x28, rsi
	670 Move r9, 10
	671 Move r8, 0
	672 Move stack:0x20, xmm0
	673 Move rcx, rbx
	674 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	675 Move [rbx+136], 25
	676 Goto {1338}
	677 Compare [rbx+160], 0
	678 JumpIfNotEqual {723}
	679 Compare [0x184EEB658], 0
	680 Move rdi, "anim_grow"
	681 JumpIfNotEqual {687}
	682 LoadAddress rcx, [0x184C92A80]
	683 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	684 LoadAddress rcx, [0x184C911F8]
	685 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	686 Move [0x184EEB658], 1
	687 Compare rdi, 0
	688 JumpIfEqual {1355}
	689 Move r8, ""
	690 Move r9, 0
	691 Move rdx, "anim_"
	692 Move rcx, rdi
	693 Call String.Replace, rcx, rdx, r8
	694 Move rcx, [rbx+320]
	695 Move rdi, rax
	696 Compare rcx, 0
	697 JumpIfEqual {1355}
	698 Move xmm1, [0x183C33DAC]
	699 Move r9, 0
	700 Move r8, 0
	701 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	702 Move rcx, [rbx+320]
	703 Compare rcx, 0
	704 JumpIfEqual {1355}
	705 Move xmm3, [0x183C33DB4]
	706 Move rsi, 0
	707 Move stack:0x28, rsi
	708 Move r8, 0
	709 Move rdx, rdi
	710 Move stack:0x20, 3
	711 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	712 Move r8, [rbx+16]
	713 Move [rbx+136], 24
	714 Compare r8, 0
	715 JumpIfEqual {1355}
	716 Move r8, [r8+88]
	717 Compare r8, 0
	718 JumpIfEqual {1355}
	719 Move rdx, typeof(Reloaded.Services.IAudioService)
	720 Move rcx, 6
	721 Move r9, 63
	722 Call 0x180002040, rcx, rdx, r8, r9
	723 Move rdx, 0
	724 Move rcx, rbx
	725 Call Plant.UpdateProductionPlant, rcx, rdx
	726 Goto {1338}
	727 Move rdx, 0
	728 Move rcx, rbx
	729 Call Plant.UpdateGoldMagnetShroom, rcx, rdx
	730 Goto {1338}
	731 Move rdx, 0
	732 Move rcx, rbx
	733 Call Plant.UpdateMagnetShroom, rcx, rdx
	734 Goto {1338}
	735 Move rdx, 0
	736 Move rcx, rbx
	737 Call Plant.UpdateCactus, rcx, rdx
	738 Goto {1338}
	739 Compare [0x184EEB66E], 0
	740 JumpIfNotEqual {748}
	741 LoadAddress rcx, [0x184C2AFC0]
	742 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	743 LoadAddress rcx, [0x184C75168]
	744 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	745 LoadAddress rcx, [0x184C93800]
	746 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	747 Move [0x184EEB66E], 1
	748 Compare [rbx+136], 35
	749 JumpIfEqual {833}
	750 Compare [rbx+136], 36
	751 JumpIfEqual {800}
	752 Compare [rbx+136], 37
	753 JumpIfEqual {776}
	754 Compare [rbx+136], 38
	755 JumpIfNotEqual {1338}
	756 Move rcx, [rbx+320]
	757 Compare rcx, 0
	758 JumpIfEqual {1355}
	759 Move xmm1, [0x183C33F94]
	760 Move r9, 0
	761 Move r8, 0
	762 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	763 Compare rax, 0
	764 JumpIfEqual {1338}
	765 Move rax, [rbx+16]
	766 Compare rax, 0
	767 JumpIfEqual {1355}
	768 Move r8, [rax+88]
	769 Compare r8, 0
	770 JumpIfEqual {1355}
	771 Move rdx, typeof(Reloaded.Services.IAudioService)
	772 Move rcx, 6
	773 Move r9, 76
	774 Call 0x180002040, rcx, rdx, r8, r9
	775 Goto {1338}
	776 Move rax, [rbx+24]
	777 Move rdi, [rbx+320]
	778 Compare rax, 0
	779 JumpIfEqual {1355}
	780 Move rcx, typeof(Reloaded.Gameplay.Common)
	781 Move rsi, [rax+492]
	782 Compare [rcx+228], 0
	783 JumpIfNotEqual {785}
	784 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	785 Move r9, 0
	786 LoadAddress rcx, stack:0x60
	787 Move r8, 75
	788 Move rdx, rsi
	789 Call Common.GetFlashingColor, rcx, rdx, r8
	790 Compare rdi, 0
	791 JumpIfEqual {1355}
	792 Move xmm0, [rax]
	793 Move r9, 0
	794 LoadAddress rdx, stack:0x50
	795 Move r8, 0
	796 Move rcx, rdi
	797 Move stack:0x50, xmm0
	798 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	799 Goto {1338}
	800 Move rcx, [rbx+320]
	801 Compare rcx, 0
	802 JumpIfEqual {1355}
	803 Move xmm1, [0x183C33C40]
	804 Move r9, 0
	805 Move r8, 0
	806 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	807 Compare rax, 0
	808 JumpIfEqual {819}
	809 Move rax, [rbx+16]
	810 Compare rax, 0
	811 JumpIfEqual {1355}
	812 Move r8, [rax+88]
	813 Compare r8, 0
	814 JumpIfEqual {1355}
	815 Move rdx, typeof(Reloaded.Services.IAudioService)
	816 Move rcx, 6
	817 Move r9, 64
	818 Call 0x180002040, rcx, rdx, r8, r9
	819 Move rcx, [rbx+320]
	820 Compare rcx, 0
	821 JumpIfEqual {1355}
	822 Move r8, 0
	823 Move rdx, 0
	824 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	825 Compare rax, 0
	826 JumpIfLessOrEqual {1338}
	827 Move xmm1, [0x183C33DB4]
	828 Move r8, 0
	829 Move rcx, rbx
	830 Move [rbx+136], 37
	831 Call Plant.PlayIdleAnim, rcx, rdx
	832 Goto {1338}
	833 Compare [rbx+160], 0
	834 JumpIfNotEqual {1338}
	835 Compare [0x184EEB658], 0
	836 Move [rbx+136], 36
	837 Move rdi, "anim_charge"
	838 JumpIfNotEqual {844}
	839 LoadAddress rcx, [0x184C92A80]
	840 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	841 LoadAddress rcx, [0x184C911F8]
	842 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	843 Move [0x184EEB658], 1
	844 Compare rdi, 0
	845 JumpIfEqual {1355}
	846 Move r8, ""
	847 Move r9, 0
	848 Move rdx, "anim_"
	849 Move rcx, rdi
	850 Call String.Replace, rcx, rdx, r8
	851 Move rcx, [rbx+320]
	852 Move rdi, rax
	853 Compare rcx, 0
	854 JumpIfEqual {1355}
	855 Move xmm1, [0x183C33DBC]
	856 Move r9, 0
	857 Move r8, 0
	858 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	859 Move rcx, [rbx+320]
	860 Compare rcx, 0
	861 JumpIfEqual {1355}
	862 Move xmm3, [0x183C33DB4]
	863 Move rsi, 0
	864 Move stack:0x28, rsi
	865 Move r8, 0
	866 Move rdx, rdi
	867 Move stack:0x20, 3
	868 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	869 Goto {1338}
	870 Compare [rbx+136], 40
	871 JumpIfEqual {893}
	872 Compare [rbx+136], 41
	873 JumpIfNotEqual {1338}
	874 Move rcx, [rbx+320]
	875 Compare rcx, 0
	876 JumpIfEqual {1355}
	877 Move r8, 0
	878 Move rdx, 0
	879 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	880 Compare rax, 0
	881 JumpIfLessOrEqual {1338}
	882 Move xmm1, [0x183C33DAC]
	883 Move r8, 0
	884 Move rcx, rbx
	885 Call Plant.PlayIdleAnim, rcx, rdx
	886 Move rsi, 0
	887 Move rdx, 0
	888 Move rcx, rbx
	889 Move [rbx+136], rsi
	890 Call Plant.CalcRenderOrder, rcx, rdx
	891 Move [rbx+56], rax
	892 Goto {1338}
	893 Compare [rbx+160], 0
	894 JumpIfNotEqual {1338}
	895 Move rdx, [rbx+52]
	896 Move r9, 0
	897 Add rdx, rdx, 1
	898 Move r8, 0
	899 Move rcx, 0x4A768
	900 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	901 Move [rbx+56], rax
	902 Move [rbx+136], 41
	903 Goto {1338}
	904 Compare [rbx+136], 2
	905 JumpIfNotEqual {1338}
	906 Move rcx, [rbx+320]
	907 Compare rcx, 0
	908 JumpIfEqual {1355}
	909 Move r8, 0
	910 Move rdx, 0
	911 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	912 Compare rax, 0
	913 JumpIfLessOrEqual {1338}
	914 Move rdx, 0
	915 Move rcx, rbx
	916 Call Plant.Die, rcx, rdx
	917 Goto {1338}
	918 Compare [0x184EEB675], 0
	919 JumpIfNotEqual {923}
	920 LoadAddress rcx, [0x184C949B8]
	921 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	922 Move [0x184EEB675], 1
	923 Compare [rbx+136], 42
	924 JumpIfNotEqual {978}
	925 Move rcx, [rbx+320]
	926 Compare rcx, 0
	927 JumpIfEqual {1355}
	928 Move xmm1, [0x183C33EBC]
	929 Move r9, 0
	930 Move r8, 0
	931 Call ReloadedCharacterController.ShouldTriggerTimedEvent, rcx, rdx, r8
	932 Move rsi, 0
	933 Compare rax, 0
	934 JumpIfEqual {946}
	935 Move rcx, [rbx+16]
	936 Compare rcx, 0
	937 JumpIfEqual {1355}
	938 Move xmm2, [rbx+36]
	939 Move r9, 0x61A80
	940 Move xmm1, [rbx+32]
	941 Add xmm2, xmm2, [0x183C33DC4]
	942 Add xmm1, xmm1, [0x183C33DC4]
	943 Move stack:0x28, rsi
	944 Move stack:0x20, 71
	945 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	946 Move rcx, [rbx+320]
	947 Compare rcx, 0
	948 JumpIfEqual {1355}
	949 Move r8, 0
	950 Move rdx, 0
	951 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	952 Compare rax, 0
	953 JumpIfLessOrEqual {1338}
	954 Move rdx, 0
	955 Move rcx, rbx
	956 Call Plant.Die, rcx, rdx
	957 Move rcx, [rbx+24]
	958 Compare rcx, 0
	959 JumpIfEqual {1355}
	960 Move r9, [rbx+300]
	961 Move r8, [rbx+52]
	962 Move rdx, [rbx+116]
	963 Move stack:0x38, rsi
	964 Move stack:0x30, rsi
	965 Move stack:0x28, rsi
	966 Move stack:0x20, 48
	967 Call Board.AddPlant, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	968 Move rdi, rax
	969 Compare rax, 0
	970 JumpIfEqual {1355}
	971 Move rcx, [rax+320]
	972 Compare rcx, 0
	973 JumpIfEqual {1355}
	974 Move rdx, 0
	975 Call PlantController.EnableGrayscale, rcx, rdx
	976 Move [rdi+313], 1
	977 Goto {1338}
	978 Compare [rbx+160], 0
	979 JumpIfNotEqual {1338}
	980 Compare [0x184EEB658], 0
	981 Move [rbx+136], 42
	982 Move rdi, "anim_explode"
	983 JumpIfNotEqual {989}
	984 LoadAddress rcx, [0x184C92A80]
	985 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	986 LoadAddress rcx, [0x184C911F8]
	987 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	988 Move [0x184EEB658], 1
	989 Compare rdi, 0
	990 JumpIfEqual {1355}
	991 Move r8, ""
	992 Move r9, 0
	993 Move rdx, "anim_"
	994 Move rcx, rdi
	995 Call String.Replace, rcx, rdx, r8
	996 Move rcx, [rbx+320]
	997 Compare rcx, 0
	998 JumpIfEqual {1355}
	999 Move xmm3, [0x183C33FB0]
	1000 Move rsi, 0
	1001 Move stack:0x28, rsi
	1002 Move r8, 0
	1003 Move rdx, rax
	1004 Move stack:0x20, 3
	1005 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	1006 Goto {1338}
	1007 Compare [rbx+136], 48
	1008 JumpIfNotEqual {1338}
	1009 Compare [rbx+160], 0
	1010 JumpIfEqual {1016}
	1011 Goto {1338}
	1012 Compare [rbx+136], 47
	1013 JumpIfNotEqual {1338}
	1014 Compare [rbx+160], 0
	1015 JumpIfNotEqual {1338}
	1016 Move rsi, 0
	1017 Move [rbx+136], rsi
	1018 Goto {1338}
	1019 Compare [0x184EEB669], 0
	1020 JumpIfNotEqual {1024}
	1021 LoadAddress rcx, [0x184C2A910]
	1022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1023 Move [0x184EEB669], 1
	1024 Move rcx, [rbx+320]
	1025 Compare rcx, 0
	1026 JumpIfEqual {1355}
	1027 Move r8, 0
	1028 Move rdx, 0
	1029 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	1030 Compare rax, 0
	1031 JumpIfLessOrEqual {1047}
	1032 Move rcx, [rbx+320]
	1033 Compare rcx, 0
	1034 JumpIfEqual {1355}
	1035 Move r8, 0
	1036 Move rdx, 0
	1037 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	1038 Compare rax, 0
	1039 JumpIfEqual {1047}
	1040 Move rcx, [rbx+320]
	1041 Compare rcx, 0
	1042 JumpIfEqual {1355}
	1043 Move rdx, "loop"
	1044 Move r9, 0
	1045 Move r8, 0
	1046 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	1047 Compare [rbx+136], 2
	1048 JumpIfEqual {1338}
	1049 Compare [rbx+156], 0
	1050 JumpIfNotEqual {1338}
	1051 Move rdx, 0
	1052 Move rcx, rbx
	1053 Call Plant.DoSpecial, rcx, rdx
	1054 Goto {1338}
	1055 Compare [0x184EEB655], 0
	1056 JumpIfNotEqual {1066}
	1057 LoadAddress rcx, [0x184C75168]
	1058 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1059 LoadAddress rcx, [0x184C932A8]
	1060 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1061 LoadAddress rcx, [0x184C39168]
	1062 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1063 LoadAddress rcx, [0x184CADDD0]
	1064 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1065 Move [0x184EEB655], 1
	1066 Compare [rbx+136], 1
	1067 JumpIfEqual {1229}
	1068 Compare [rbx+136], 10
	1069 JumpIfEqual {1147}
	1070 Compare [rbx+136], 11
	1071 JumpIfEqual {1113}
	1072 Compare [rbx+136], 13
	1073 JumpIfEqual {1092}
	1074 Compare [rbx+136], 14
	1075 JumpIfEqual {1078}
	1076 Compare [rbx+136], 12
	1077 JumpIfNotEqual {1338}
	1078 Move rcx, [rbx+320]
	1079 Compare rcx, 0
	1080 JumpIfEqual {1355}
	1081 Move r8, 0
	1082 Move rdx, 0
	1083 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	1084 Compare rax, 0
	1085 JumpIfLessOrEqual {1338}
	1086 Move xmm1, [0x183C33DB4]
	1087 Move r8, 0
	1088 Move rcx, rbx
	1089 Call Plant.PlayIdleAnim, rcx, rdx
	1090 Move [rbx+136], 1
	1091 Goto {1338}
	1092 Compare [rbx+160], 0
	1093 JumpIfNotEqual {1338}
	1094 Move rcx, [rbx+320]
	1095 Compare rcx, 0
	1096 JumpIfEqual {1355}
	1097 Move xmm1, [0x183C33DBC]
	1098 Move r9, 0
	1099 Move r8, 0
	1100 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	1101 Move rcx, [rbx+320]
	1102 Compare rcx, 0
	1103 JumpIfEqual {1355}
	1104 Move xmm3, [0x183C33DB4]
	1105 Move rsi, 0
	1106 Move rdx, "swallow"
	1107 Move r8, 0
	1108 Move stack:0x28, rsi
	1109 Move stack:0x20, 3
	1110 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	1111 Move [rbx+136], 14
	1112 Goto {1338}
	1113 Move rcx, [rbx+320]
	1114 Compare rcx, 0
	1115 JumpIfEqual {1355}
	1116 Move r8, 0
	1117 Move rdx, 0
	1118 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	1119 Compare rax, 0
	1120 JumpIfLessOrEqual {1338}
	1121 Move rcx, [rbx+320]
	1122 Compare rcx, 0
	1123 JumpIfEqual {1355}
	1124 Move xmm3, [0x183C33DB8]
	1125 Move rsi, 0
	1126 Move rdx, "chew"
	1127 Move r8, 0
	1128 Move stack:0x20, rsi
	1129 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	1130 Move rcx, [rbx+16]
	1131 Compare rcx, 0
	1132 JumpIfEqual {1355}
	1133 Move rdx, 0
	1134 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	1135 Compare rax, 0
	1136 JumpIfEqual {1144}
	1137 Move rcx, [rbx+320]
	1138 Compare rcx, 0
	1139 JumpIfEqual {1355}
	1140 Move r9, 0
	1141 Move r8, 0
	1142 Move xmm1, 0
	1143 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	1144 Move [rbx+136], 13
	1145 Move [rbx+160], 4000
	1146 Goto {1338}
	1147 Compare [rbx+160], 0
	1148 JumpIfNotEqual {1338}
	1149 Move rax, [rbx+16]
	1150 Compare rax, 0
	1151 JumpIfEqual {1355}
	1152 Move r8, [rax+88]
	1153 Compare r8, 0
	1154 JumpIfEqual {1355}
	1155 Move rdx, typeof(Reloaded.Services.IAudioService)
	1156 Move rcx, 6
	1157 Move r9, 61
	1158 Call 0x180002040, rcx, rdx, r8, r9
	1159 Move rdx, [rbx+52]
	1160 Move r9, 0
	1161 Move r8, 0
	1162 Move rcx, rbx
	1163 Call Plant.FindTargetZombie, rcx, rdx, r8
	1164 Move rbp, 0
	1165 Move rdi, rax
	1166 Compare rax, 0
	1167 JumpIfEqual {1177}
	1168 Compare [rax+112], 23
	1169 JumpIfEqual {1174}
	1170 Compare [rax+112], 32
	1171 JumpIfEqual {1174}
	1172 Compare [rax+112], 25
	1173 JumpIfNotEqual {1177}
	1174 Move rbp, 1
	1175 Move rsi, 0
	1176 Goto {1180}
	1177 Move rsi, 0
	1178 Compare rdi, 0
	1179 JumpIfEqual {1194}
	1180 Move rdx, 0
	1181 Move rcx, rdi
	1182 Call Zombie.IsImmobilizied, rcx, rdx
	1183 Compare rax, 0
	1184 JumpIfNotEqual {1195}
	1185 Move rdx, 0
	1186 Move rcx, rdi
	1187 Call Zombie.IsBouncingPogo, rcx, rdx
	1188 Compare rax, 0
	1189 JumpIfNotEqual {1194}
	1190 Compare [rdi+116], 12
	1191 JumpIfEqual {1194}
	1192 Compare [rdi+116], 11
	1193 JumpIfNotEqual {1195}
	1194 Move rsi, 1
	1195 Compare rbp, 0
	1196 JumpIfNotEqual {1210}
	1197 Compare rsi, 0
	1198 JumpIfNotEqual {1227}
	1199 Compare rdi, 0
	1200 JumpIfEqual {1355}
	1201 Move rdx, 0
	1202 Move rcx, rdi
	1203 Call Zombie.DieWithLoot, rcx, rdx
	1204 Move rax, [rbx+24]
	1205 Compare rax, 0
	1206 JumpIfEqual {1355}
	1207 Move [rax+569], rsi
	1208 Move [rbx+136], 11
	1209 Goto {1338}
	1210 Move rax, [rbx+16]
	1211 Compare rax, 0
	1212 JumpIfEqual {1355}
	1213 Move r8, [rax+88]
	1214 Compare r8, 0
	1215 JumpIfEqual {1355}
	1216 Move rdx, typeof(Reloaded.Services.IAudioService)
	1217 Move rcx, 6
	1218 Move r9, 1
	1219 Call 0x180002040, rcx, rdx, r8, r9
	1220 Compare rdi, 0
	1221 JumpIfEqual {1355}
	1222 Move r9, 0
	1223 Move r8, 0
	1224 Move rdx, 40
	1225 Move rcx, rdi
	1226 Call Zombie.TakeDamage, rcx, rdx, r8
	1227 Move [rbx+136], 12
	1228 Goto {1338}
	1229 Move rdx, [rbx+52]
	1230 Move r9, 0
	1231 Move r8, 0
	1232 Move rcx, rbx
	1233 Call Plant.FindTargetZombie, rcx, rdx, r8
	1234 Compare rax, 0
	1235 JumpIfEqual {1338}
	1236 Move rcx, [rbx+320]
	1237 Compare rcx, 0
	1238 JumpIfEqual {1355}
	1239 Move xmm1, [0x183C33DBC]
	1240 Move r9, 0
	1241 Move r8, 0
	1242 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	1243 Move rcx, [rbx+320]
	1244 Compare rcx, 0
	1245 JumpIfEqual {1355}
	1246 Move r9, 0
	1247 Move r8, 0
	1248 Move rdx, 3
	1249 Call ReloadedCharacterController.SetAnimLoopType, rcx, rdx, r8
	1250 Move rcx, [rbx+320]
	1251 Compare rcx, 0
	1252 JumpIfEqual {1355}
	1253 Move xmm3, [0x183C33EF0]
	1254 Move rsi, 0
	1255 Move rdx, "bite"
	1256 Move r8, 0
	1257 Move stack:0x28, rsi
	1258 Move stack:0x20, 3
	1259 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	1260 Move [rbx+136], 10
	1261 Move [rbx+160], 70
	1262 Goto {1338}
	1263 Compare [rbx+310], 0
	1264 JumpIfNotEqual {1338}
	1265 Compare [rbx+136], 2
	1266 JumpIfEqual {1338}
	1267 Move [rbx+136], 2
	1268 Move [rbx+156], 100
	1269 Goto {1338}
	1270 Compare [0x184EEB65B], 0
	1271 JumpIfNotEqual {1283}
	1272 LoadAddress rcx, [0x184C75168]
	1273 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1274 LoadAddress rcx, [0x184C8DF20]
	1275 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1276 LoadAddress rcx, [0x184C70610]
	1277 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1278 LoadAddress rcx, [0x184C8DD70]
	1279 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1280 LoadAddress rcx, [0x184C8DE48]
	1281 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	1282 Move [0x184EEB65B], 1
	1283 Compare [rbx+310], 0
	1284 JumpIfNotEqual {1338}
	1285 Compare [rbx+136], 2
	1286 JumpIfEqual {1338}
	1287 Move rcx, [rbx+320]
	1288 Move [rbx+136], 2
	1289 Move [rbx+156], 100
	1290 Compare rcx, 0
	1291 JumpIfEqual {1355}
	1292 Move xmm3, [0x183C33EEC]
	1293 Move rsi, 0
	1294 Move rdx, "explode"
	1295 Move r8, 0
	1296 Move stack:0x28, rsi
	1297 Move stack:0x20, 3
	1298 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	1299 Move rcx, [rbx+320]
	1300 Compare rcx, 0
	1301 JumpIfEqual {1355}
	1302 Move xmm2, [0x183C33C4C]
	1303 Move r9, 0
	1304 Move rdx, "DoomShroom_head1"
	1305 Move stack:0x20, rsi
	1306 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	1307 Move rcx, [rbx+320]
	1308 Compare rcx, 0
	1309 JumpIfEqual {1355}
	1310 Move xmm6, typeof(T)
	1311 Move r9, 0
	1312 Move rdx, "DoomShroom_head2"
	1313 Move xmm2, xmm6
	1314 Move stack:0x20, rsi
	1315 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	1316 Move rcx, [rbx+320]
	1317 Compare rcx, 0
	1318 JumpIfEqual {1355}
	1319 Move rdx, "DoomShroom_head3"
	1320 Move r9, 0
	1321 Move xmm2, xmm6
	1322 Move stack:0x20, rsi
	1323 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	1324 Move r8, [rbx+16]
	1325 Compare r8, 0
	1326 JumpIfEqual {1355}
	1327 Move r8, [r8+88]
	1328 Compare r8, 0
	1329 JumpIfEqual {1355}
	1330 Move rdx, typeof(Reloaded.Services.IAudioService)
	1331 Move rcx, 6
	1332 Move r9, 57
	1333 Call 0x180002040, rcx, rdx, r8, r9
	1334 Goto {1338}
	1335 Move rdx, 0
	1336 Move rcx, rbx
	1337 Call Plant.UpdateSquash, rcx, rdx
	1338 Compare [rbx+148], 1
	1339 JumpIfNotEqual {1343}
	1340 Move rdx, 0
	1341 Move rcx, rbx
	1342 Call Plant.UpdateShooter, rcx, rdx
	1343 Compare [rbx+156], 0
	1344 JumpIfLessOrEqual {96}
	1345 Subtract [rbx+156], [rbx+156], 1
	1346 JumpIfNotEqual {96}
	1347 Move rdx, 0
	1348 Move rcx, rbx
	1349 Call Plant.DoSpecial, rcx, rdx
	1350 Goto {96}
	1351 Move rdx, 0
	1352 Move rcx, rbx
	1353 Call Plant.Die, rcx, rdx
	1354 Goto {96}
	1355 Call 0x1804FEE20, rcx, rdx, r8, r9
	1356 Interrupt 
	1357 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
