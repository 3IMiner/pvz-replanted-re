# System.Void UpdateMagnetShroom()

- 类：`Plant`
- 汇编行数：1251

## 反汇编

```asm

Disassembly:
	push rbx
	push rbp
	push rsi
	push rdi
	push r14
	sub rsp,100h
	cmp byte ptr [184EEB659h],0
	mov rbx,rcx
	movaps [rsp+90h],xmm12
	movaps [rsp+70h],xmm14
	jne short 00000001806B9C68h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C7E798h]
	call 00000001804FEB70h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C7E870h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C984C0h]
	call 00000001804FEB70h
	lea rcx,[184C974B8h]
	call 00000001804FEB70h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB659h],1
	movss xmm14,dword ptr [183C33DBCh]
	xor r14d,r14d
	movss xmm12,dword ptr [183C33C34h]
	mov ebp,r14d
	mov [rsp+130h],r12
	mov esi,20h
	mov [rsp+138h],r13
	mov [rsp+148h],r15
	movaps [rsp+0F0h],xmm6
	movaps [rsp+0E0h],xmm7
	movaps [rsp+0D0h],xmm8
	movaps [rsp+0C0h],xmm9
	movaps [rsp+0B0h],xmm10
	movaps [rsp+0A0h],xmm11
	movaps [rsp+80h],xmm13
	movaps [rsp+60h],xmm15
	mov rdi,[rbx+118h]
	test rdi,rdi
	je near ptr 00000001806BA69Ch
	cmp ebp,[rdi+18h]
	jae near ptr 00000001806BA696h
	mov rdi,[rsi+rdi]
	test rdi,rdi
	je near ptr 00000001806BA69Ch
	cmp [rdi+20h],r14d
	je short 00000001806B9D60h
	movss xmm6,dword ptr [rdi+18h]
	xor edx,edx
	addss xmm6,dword ptr [rbx+20h]
	movss xmm7,dword ptr [rdi+1Ch]
	addss xmm7,dword ptr [rbx+24h]
	subss xmm6,dword ptr [rdi+10h]
	subss xmm7,dword ptr [rdi+14h]
	movaps xmm0,xmm6
	unpcklps xmm0,xmm7
	movq rcx,xmm0
	call 00000001806AB080h
	comiss xmm14,xmm0
	ja short 00000001806B9D60h
	mulss xmm6,xmm12
	mulss xmm7,xmm12
	addss xmm6,dword ptr [rdi+10h]
	movss dword ptr [rdi+10h],xmm6
	addss xmm7,dword ptr [rdi+14h]
	movss dword ptr [rdi+14h],xmm7
	inc ebp
	add rsi,8
	cmp rsi,48h
	jl near ptr 00000001806B9CE0h
	cmp dword ptr [rbx+88h],1Bh
	je near ptr 00000001806BA4C3h
	cmp dword ptr [rbx+88h],1Ah
	je near ptr 00000001806BA3B2h
	mov rax,[rbx+18h]
	mov r13,r14
	xorps xmm11,xmm11
	xorps xmm10,xmm10
	mov ebp,r14d
	mov edx,r14d
	test rax,rax
	je near ptr 00000001806BA69Ch
	movss xmm13,dword ptr [183C33DE8h]
	movss xmm15,dword ptr [183C33DCCh]
	nop word ptr [rax+rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	cmp edx,[rcx+28h]
	jge near ptr 00000001806B9FFAh
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BA69Ch
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	mov r8,[184C81528h]
	mov edx,ebp
	call 0000000182449330h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806BA69Ch
	xor r8d,r8d
	lea rcx,[rsp+50h]
	mov rdx,rax
	call 00000001806F2D70h
	mov r12d,[rbx+34h]
	movups xmm7,[rax]
	mov eax,[rdi+34h]
	mov r15d,eax
	sub r15d,r12d
	mov [rsp+140h],eax
	cmp [rdi+110h],r14b
	jne near ptr 00000001806B9FE4h
	cmp [rdi+112h],r14b
	je near ptr 00000001806B9FE4h
	cmp [rdi+0B8h],r14d
	jne near ptr 00000001806B9FE4h
	cmp dword ptr [rdi+74h],0Eh
	je near ptr 00000001806B9FE4h
	xor edx,edx
	mov rcx,rdi
	call 00000001806F3600h
	test al,al
	jne near ptr 00000001806B9FE4h
	comiss xmm7,xmm13
	ja near ptr 00000001806B9FE4h
	lea eax,[r15+2]
	cmp eax,4
	ja near ptr 00000001806B9FE4h
	cmp dword ptr [rdi+74h],20h
	je short 00000001806B9EDCh
	cmp dword ptr [rdi+74h],24h
	je short 00000001806B9EDCh
	cmp dword ptr [rdi+74h],25h
	je short 00000001806B9EDCh
	cmp dword ptr [rdi+70h],12h
	je short 00000001806B9EDCh
	cmp dword ptr [rdi+11Ch],2
	je short 00000001806B9EE9h
	cmp dword ptr [rdi+11Ch],3
	je short 00000001806B9EE9h
	cmp dword ptr [rdi+130h],1
	je short 00000001806B9EE9h
	cmp dword ptr [rdi+130h],3
	je short 00000001806B9EE9h
	cmp dword ptr [rdi+130h],5
	je short 00000001806B9EE9h
	cmp dword ptr [rdi+74h],0Fh
	jne near ptr 00000001806B9FE4h
	jmp short 00000001806B9EE9h
	cmp [rdi+114h],r14b
	je near ptr 00000001806B9FE4h
	cmp [rdi+0A5h],r14b
	mov esi,140h
	mov rcx,[184C2AFC0h]
	mov eax,10Eh
	movss xmm9,dword ptr [rbx+20h]
	movaps xmm8,xmm7
	movss xmm6,dword ptr [rbx+24h]
	movaps xmm0,xmm7
	movaps xmm1,xmm7
	shufps xmm8,xmm7,55h
	cmove esi,eax
	shufps xmm0,xmm7,0AAh
	shufps xmm1,xmm7,0FFh
	movss dword ptr [rsp+30h],xmm7
	movss dword ptr [rsp+34h],xmm8
	movss dword ptr [rsp+38h],xmm0
	movss dword ptr [rsp+3Ch],xmm1
	cmp [rcx+0E4h],r14d
	jne short 00000001806B9F4Dh
	call 00000001804FEEB0h
	movups xmm1,[rsp+30h]
	mov [rsp+20h],r14
	lea r9,[rsp+40h]
	addss xmm6,xmm14
	mov r8d,esi
	movdqa [rsp+40h],xmm1
	movaps xmm0,xmm9
	movaps xmm1,xmm6
	call 00000001806CB910h
	test al,al
	je short 00000001806B9FE4h
	movss xmm6,dword ptr [rbx+20h]
	movss xmm9,dword ptr [rbx+24h]
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806B9F9Ah
	call 00000001804FEEB0h
	movaps xmm3,xmm8
	mov [rsp+20h],r14
	movaps xmm2,xmm7
	movaps xmm1,xmm9
	movaps xmm0,xmm6
	call 00000001806CB840h
	sub r12d,[rsp+140h]
	cmp r12d,r15d
	cmovle r12d,r15d
	movd xmm1,r12d
	cvtdq2ps xmm1,xmm1
	mulss xmm1,xmm15
	addss xmm1,xmm0
	test r13,r13
	je short 00000001806B9FDDh
	comiss xmm10,xmm1
	jbe short 00000001806B9FE4h
	mov r13,rdi
	movaps xmm10,xmm1
	mov rax,[rbx+18h]
	inc ebp
	mov edx,ebp
	test rax,rax
	je near ptr 00000001806BA69Ch
	jmp near ptr 00000001806B9DC0h
	test r13,r13
	jne near ptr 00000001806BA39Fh
	mov rax,[rbx+18h]
	mov rsi,r14
	mov edi,r14d
	mov edx,r14d
	test rax,rax
	je near ptr 00000001806BA69Ch
	nop dword ptr [rax]
	mov rcx,[rax+98h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	cmp edx,[rcx+28h]
	jge near ptr 00000001806BA0FAh
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806BA69Ch
	mov rcx,[rax+98h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	mov r8,[184C7E870h]
	mov edx,edi
	call 0000000182449330h
	mov r9,rax
	test rax,rax
	je near ptr 00000001806BA69Ch
	cmp dword ptr [rax+70h],3
	jne short 00000001806BA0E4h
	mov r11d,[rax+7Ch]
	mov r8d,[rbx+74h]
	mov eax,[rax+78h]
	mov r10d,[rbx+34h]
	sub eax,r8d
	sub r11d,r10d
	sub r8d,[r9+78h]
	cmp r8d,eax
	cmovle r8d,eax
	sub r10d,[r9+7Ch]
	cmp r10d,r11d
	cmovle r10d,r11d
	cmp r8d,r10d
	cmovg r10d,r8d
	cmp r10d,2
	jg short 00000001806BA0E4h
	mov eax,r11d
	neg eax
	cmp eax,r11d
	movd xmm0,r10d
	cvtdq2ps xmm0,xmm0
	cmovle eax,r11d
	movd xmm1,eax
	cvtdq2ps xmm1,xmm1
	mulss xmm1,xmm12
	addss xmm1,xmm0
	test rsi,rsi
	je short 00000001806BA0DDh
	comiss xmm11,xmm1
	jbe short 00000001806BA0E4h
	mov rsi,r9
	movaps xmm11,xmm1
	mov rax,[rbx+18h]
	inc edi
	mov edx,edi
	test rax,rax
	jne near ptr 00000001806BA020h
	jmp near ptr 00000001806BA69Ch
	test rsi,rsi
	je near ptr 00000001806BA327h
	cmp [184EEB658h],r14b
	mov dword ptr [rbx+88h],1Ah
	mov dword ptr [rbx+0A0h],5DCh
	mov rdi,[184C984C0h]
	jne short 00000001806BA146h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BA69Ch
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm14
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	movss xmm3,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov [rsp+28h],r14
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806BA69Ch
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806BA69Ch
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,2Ah
	call 0000000180002040h
	xor edx,edx
	mov rcx,rsi
	call 00000001806C2390h
	cmp dword ptr [rbx+70h],2Dh
	mov r9,[rbx+118h]
	je short 00000001806BA21Bh
	test r9,r9
	je near ptr 00000001806BA69Ch
	cmp [r9+18h],r14d
	jbe near ptr 00000001806BA696h
	mov r14,[r9+20h]
	jmp short 00000001806BA270h
	nop dword ptr [rax+rax]
	lea rdx,[r9+20h]
	mov rcx,r14
	mov eax,r14d
	test r9,r9
	je near ptr 00000001806BA69Ch
	cmp eax,[r9+18h]
	jae near ptr 00000001806BA696h
	mov r8,[rdx]
	test r8,r8
	je near ptr 00000001806BA69Ch
	cmp [r8+20h],r14d
	je short 00000001806BA260h
	inc eax
	inc rcx
	add rdx,8
	cmp rcx,5
	jl short 00000001806BA233h
	jmp short 00000001806BA270h
	test r9,r9
	je near ptr 00000001806BA69Ch
	cdqe
	mov r14,[r9+rax*8+20h]
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	mov r8d,[rsi+7Ch]
	xor r9d,r9d
	mov edx,[rsi+78h]
	call 000000018065F590h
	test r14,r14
	je near ptr 00000001806BA69Ch
	add eax,28h
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	movss dword ptr [r14+10h],xmm0
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	mov r8d,[rsi+7Ch]
	xor r9d,r9d
	mov edx,[rsi+78h]
	call 000000018065F630h
	movd xmm0,eax
	cvtdq2ps xmm0,xmm0
	movss dword ptr [r14+14h],xmm0
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BA2E3h
	call 00000001804FEEB0h
	movss xmm7,dword ptr [183C33DACh]
	xor r8d,r8d
	movss xmm6,dword ptr [183C33F38h]
	movaps xmm1,xmm7
	movaps xmm0,xmm6
	call 00000001806CBD40h
	addss xmm0,xmm7
	xor r8d,r8d
	movaps xmm1,xmm7
	movss dword ptr [r14+18h],xmm0
	movaps xmm0,xmm6
	call 00000001806CBD40h
	movss dword ptr [r14+1Ch],xmm0
	mov dword ptr [r14+20h],11h
	movaps xmm15,[rsp+60h]
	movaps xmm13,[rsp+80h]
	movaps xmm11,[rsp+0A0h]
	movaps xmm10,[rsp+0B0h]
	movaps xmm9,[rsp+0C0h]
	movaps xmm8,[rsp+0D0h]
	movaps xmm7,[rsp+0E0h]
	movaps xmm6,[rsp+0F0h]
	mov r15,[rsp+148h]
	mov r13,[rsp+138h]
	mov r12,[rsp+130h]
	movaps xmm12,[rsp+90h]
	movaps xmm14,[rsp+70h]
	add rsp,100h
	pop r14
	pop rdi
	pop rsi
	pop rbp
	pop rbx
	ret
	xor r8d,r8d
	mov rdx,r13
	mov rcx,rbx
	call 00000001806B2930h
	jmp near ptr 00000001806BA327h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BA4B4h
	cmp [184EEB658h],r14b
	mov rdi,[184C974B8h]
	jne short 00000001806BA403h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BA69Ch
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor r9d,r9d
	xor r8d,r8d
	movaps xmm1,xmm14
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	movss xmm3,dword ptr [183C33D94h]
	xor r8d,r8d
	mov [rsp+28h],r14
	mov rdx,rdi
	mov [rsp+20h],r14d
	call 00000001807C8270h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je short 00000001806BA4AAh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	mov dword ptr [rbx+88h],1Bh
	xor edx,edx
	mov rcx,rbx
	call 00000001806AE500h
	jmp near ptr 00000001806BA327h
	cmp [rbx+0A0h],r14d
	jne near ptr 00000001806BA327h
	mov dword ptr [rbx+88h],1
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BA4EFh
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DACh]
	call 00000001806CBD40h
	cmp [184EEB658h],r14b
	movaps xmm6,xmm0
	mov rdi,[184C95FA8h]
	jne short 00000001806BA539h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BA69Ch
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	movss xmm1,dword ptr [183C33C60h]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	mov [rsp+28h],r14
	movaps xmm3,xmm6
	xor r8d,r8d
	mov [rsp+20h],r14d
	mov rdx,rdi
	call 00000001807C8270h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je short 00000001806BA5DFh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	mov rax,[rbx+118h]
	test rax,rax
	je near ptr 00000001806BA69Ch
	cmp [rax+18h],r14d
	jbe near ptr 00000001806BA696h
	mov rcx,[rax+20h]
	test rcx,rcx
	je near ptr 00000001806BA69Ch
	mov [rcx+20h],r14d
	mov rax,[rbx+150h]
	test rax,rax
	je near ptr 00000001806BA69Ch
	cmp [rax+18h],r14d
	jbe short 00000001806BA696h
	mov rcx,[184C2D478h]
	mov rdi,[rax+20h]
	cmp [rcx+0E4h],r14d
	jne short 00000001806BA639h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806BA327h
	mov rax,[rbx+150h]
	test rax,rax
	je short 00000001806BA69Ch
	cmp [rax+18h],r14d
	jbe short 00000001806BA696h
	mov rcx,[rax+20h]
	test rcx,rcx
	je short 00000001806BA69Ch
	xor edx,edx
	call 00000001807B45E0h
	mov rcx,[rbx+150h]
	test rcx,rcx
	je short 00000001806BA69Ch
	cmp [rcx+18h],r14d
	jbe short 00000001806BA696h
	mov [rcx+20h],r14
	xor edx,edx
	add rcx,20h
	call 00000001804FDEA0h
	jmp near ptr 00000001806BA327h
	call 00000001804FEE10h
	int 3
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -8
	004 Move stack:0x0, rbp
	005 ShiftStack -8
	006 Move stack:0x0, rsi
	007 ShiftStack -8
	008 Move stack:0x0, rdi
	009 ShiftStack -8
	010 Move stack:0x0, r14
	011 ShiftStack -256
	012 Compare [0x184EEB659], 0
	013 Move rbx, rcx
	014 Move stack:0x90, xmm12
	015 Move stack:0x70, xmm14
	016 JumpIfNotEqual {38}
	017 LoadAddress rcx, [0x184C2AFC0]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C7E798]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 LoadAddress rcx, [0x184C81450]
	022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	023 LoadAddress rcx, [0x184C81528]
	024 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	025 LoadAddress rcx, [0x184C7E870]
	026 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	027 LoadAddress rcx, [0x184C75168]
	028 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	029 LoadAddress rcx, [0x184C2D478]
	030 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	031 LoadAddress rcx, [0x184C984C0]
	032 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	033 LoadAddress rcx, [0x184C974B8]
	034 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	035 LoadAddress rcx, [0x184C95FA8]
	036 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	037 Move [0x184EEB659], 1
	038 Move xmm14, [0x183C33DBC]
	039 Move r14, 0
	040 Move xmm12, [0x183C33C34]
	041 Move rbp, r14
	042 Move stack:0x130, r12
	043 Move rsi, 32
	044 Move stack:0x138, r13
	045 Move stack:0x148, r15
	046 Move stack:0xF0, xmm6
	047 Move stack:0xE0, xmm7
	048 Move stack:0xD0, xmm8
	049 Move stack:0xC0, xmm9
	050 Move stack:0xB0, xmm10
	051 Move stack:0xA0, xmm11
	052 Move stack:0x80, xmm13
	053 Move stack:0x60, xmm15
	054 Move rdi, [rbx+280]
	055 Compare rdi, 0
	056 JumpIfEqual {642}
	057 Compare rbp, [rdi+24]
	058 JumpIfGreaterOrEqual {640}
	059 Move rdi, [rsi+rdi]
	060 Compare rdi, 0
	061 JumpIfEqual {642}
	062 Compare [rdi+32], r14
	063 JumpIfEqual {87}
	064 Move xmm6, [rdi+24]
	065 Move rdx, 0
	066 Add xmm6, xmm6, [rbx+32]
	067 Move xmm7, [rdi+28]
	068 Add xmm7, xmm7, [rbx+36]
	069 Subtract xmm6, xmm6, [rdi+16]
	070 Subtract xmm7, xmm7, [rdi+20]
	071 Move xmm0, xmm6
	072 Move XMM_TEMP.S[0], xmm0.S[0]
	073 Move XMM_TEMP.S[1], xmm7.S[0]
	074 Move XMM_TEMP.S[2], xmm0.S[1]
	075 Move XMM_TEMP.S[3], xmm7.S[1]
	076 Move xmm0, XMM_TEMP
	077 Move rcx, xmm0
	078 Call 0x1806AB080, rcx, rdx, r8, r9
	079 Compare xmm14, xmm0
	080 JumpIfGreater {87}
	081 Multiply xmm6, xmm6, xmm12
	082 Multiply xmm7, xmm7, xmm12
	083 Add xmm6, xmm6, [rdi+16]
	084 Move [rdi+16], xmm6
	085 Add xmm7, xmm7, [rdi+20]
	086 Move [rdi+20], xmm7
	087 Add rbp, rbp, 1
	088 Add rsi, rsi, 8
	089 Compare rsi, 72
	090 JumpIfLess {54}
	091 Compare [rbx+136], 27
	092 JumpIfEqual {537}
	093 Compare [rbx+136], 26
	094 JumpIfEqual {478}
	095 Move rax, [rbx+24]
	096 Move r13, r14
	097 Move xmm11, 0
	098 Move xmm10, 0
	099 Move rbp, r14
	100 Move rdx, r14
	101 Compare rax, 0
	102 JumpIfEqual {642}
	103 Move xmm13, [0x183C33DE8]
	104 Move xmm15, [0x183C33DCC]
	105 Nop 
	106 Move rcx, [rax+112]
	107 Compare rcx, 0
	108 JumpIfEqual {642}
	109 Compare rdx, [rcx+40]
	110 JumpIfGreaterOrEqual {252}
	111 Move rax, [rbx+24]
	112 Compare rax, 0
	113 JumpIfEqual {642}
	114 Move rcx, [rax+112]
	115 Compare rcx, 0
	116 JumpIfEqual {642}
	117 Move r8, [0x184C81528]
	118 Move rdx, rbp
	119 Call 0x182449330, rcx, rdx
	120 Move rdi, rax
	121 Compare rax, 0
	122 JumpIfEqual {642}
	123 Move r8, 0
	124 LoadAddress rcx, stack:0x50
	125 Move rdx, rax
	126 Call Zombie.GetZombieRect, rcx, rdx
	127 Move r12, [rbx+52]
	128 Move xmm7, [rax]
	129 Move rax, [rdi+52]
	130 Move r15, rax
	131 Subtract r15, r15, r12
	132 Move stack:0x140, rax
	133 Compare [rdi+272], r14
	134 JumpIfNotEqual {246}
	135 Compare [rdi+274], r14
	136 JumpIfEqual {246}
	137 Compare [rdi+184], r14
	138 JumpIfNotEqual {246}
	139 Compare [rdi+116], 14
	140 JumpIfEqual {246}
	141 Move rdx, 0
	142 Move rcx, rdi
	143 Call Zombie.IsDeadOrDying, rcx, rdx
	144 Compare rax, 0
	145 JumpIfNotEqual {246}
	146 Compare xmm7, xmm13
	147 JumpIfGreater {246}
	148 LoadAddress rax, [r15+2]
	149 Compare rax, 4
	150 JumpIfGreater {246}
	151 Compare [rdi+116], 32
	152 JumpIfEqual {172}
	153 Compare [rdi+116], 36
	154 JumpIfEqual {172}
	155 Compare [rdi+116], 37
	156 JumpIfEqual {172}
	157 Compare [rdi+112], 18
	158 JumpIfEqual {172}
	159 Compare [rdi+284], 2
	160 JumpIfEqual {174}
	161 Compare [rdi+284], 3
	162 JumpIfEqual {174}
	163 Compare [rdi+304], 1
	164 JumpIfEqual {174}
	165 Compare [rdi+304], 3
	166 JumpIfEqual {174}
	167 Compare [rdi+304], 5
	168 JumpIfEqual {174}
	169 Compare [rdi+116], 15
	170 JumpIfNotEqual {246}
	171 Goto {174}
	172 Compare [rdi+276], r14
	173 JumpIfEqual {246}
	174 Compare [rdi+165], r14
	175 Move rsi, 320
	176 Move rcx, typeof(Reloaded.Gameplay.Common)
	177 Move rax, 270
	178 Move xmm9, [rbx+32]
	179 Move xmm8, xmm7
	180 Move xmm6, [rbx+36]
	181 Move xmm0, xmm7
	182 Move xmm1, xmm7
	183 Move XMM_TEMP.S[0], xmm8.S[1]
	184 Move XMM_TEMP.S[1], xmm8.S[1]
	185 Move XMM_TEMP.S[2], xmm7.S[1]
	186 Move XMM_TEMP.S[3], xmm7.S[1]
	187 Move xmm8, XMM_TEMP
	188 JumpIfNotEqual {190}
	189 Move rsi, rax
	190 Nop 
	191 Move XMM_TEMP.S[0], xmm0.S[2]
	192 Move XMM_TEMP.S[1], xmm0.S[2]
	193 Move XMM_TEMP.S[2], xmm7.S[2]
	194 Move XMM_TEMP.S[3], xmm7.S[2]
	195 Move xmm0, XMM_TEMP
	196 Move XMM_TEMP.S[0], xmm1.S[3]
	197 Move XMM_TEMP.S[1], xmm1.S[3]
	198 Move XMM_TEMP.S[2], xmm7.S[3]
	199 Move XMM_TEMP.S[3], xmm7.S[3]
	200 Move xmm1, XMM_TEMP
	201 Move stack:0x30, xmm7
	202 Move stack:0x34, xmm8
	203 Move stack:0x38, xmm0
	204 Move stack:0x3C, xmm1
	205 Compare [rcx+228], r14
	206 JumpIfNotEqual {208}
	207 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	208 Move xmm1, stack:0x30
	209 Move stack:0x20, r14
	210 LoadAddress r9, stack:0x40
	211 Add xmm6, xmm6, xmm14
	212 Move r8, rsi
	213 Move stack:0x40, xmm1
	214 Move xmm0, xmm9
	215 Move xmm1, xmm6
	216 Call Common.GetCircleRectOverlap, xmm0, xmm1, r8, r9, stack:0x0
	217 Compare rax, 0
	218 JumpIfEqual {246}
	219 Move xmm6, [rbx+32]
	220 Move xmm9, [rbx+36]
	221 Move rcx, typeof(Reloaded.Gameplay.Common)
	222 Compare [rcx+228], r14
	223 JumpIfNotEqual {225}
	224 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	225 Move xmm3, xmm8
	226 Move stack:0x20, r14
	227 Move xmm2, xmm7
	228 Move xmm1, xmm9
	229 Move xmm0, xmm6
	230 Call Common.Distance2D, xmm0, xmm1, xmm2, xmm3, stack:0x0
	231 Subtract r12, r12, stack:0x140
	232 Compare r12, r15
	233 JumpIfGreater {235}
	234 Move r12, r15
	235 Nop 
	236 Move xmm1, r12
	237 Move xmm1, xmm1
	238 Multiply xmm1, xmm1, xmm15
	239 Add xmm1, xmm1, xmm0
	240 Compare r13, 0
	241 JumpIfEqual {244}
	242 Compare xmm10, xmm1
	243 JumpIfLessOrEqual {246}
	244 Move r13, rdi
	245 Move xmm10, xmm1
	246 Move rax, [rbx+24]
	247 Add rbp, rbp, 1
	248 Move rdx, rbp
	249 Compare rax, 0
	250 JumpIfEqual {642}
	251 Goto {106}
	252 Compare r13, 0
	253 JumpIfNotEqual {473}
	254 Move rax, [rbx+24]
	255 Move rsi, r14
	256 Move rdi, r14
	257 Move rdx, r14
	258 Compare rax, 0
	259 JumpIfEqual {642}
	260 Nop 
	261 Move rcx, [rax+152]
	262 Compare rcx, 0
	263 JumpIfEqual {642}
	264 Compare rdx, [rcx+40]
	265 JumpIfGreaterOrEqual {326}
	266 Move rax, [rbx+24]
	267 Compare rax, 0
	268 JumpIfEqual {642}
	269 Move rcx, [rax+152]
	270 Compare rcx, 0
	271 JumpIfEqual {642}
	272 Move r8, [0x184C7E870]
	273 Move rdx, rdi
	274 Call 0x182449330, rcx, rdx
	275 Move r9, rax
	276 Compare rax, 0
	277 JumpIfEqual {642}
	278 Compare [rax+112], 3
	279 JumpIfNotEqual {320}
	280 Move r11, [rax+124]
	281 Move r8, [rbx+116]
	282 Move rax, [rax+120]
	283 Move r10, [rbx+52]
	284 Subtract rax, rax, r8
	285 Subtract r11, r11, r10
	286 Subtract r8, r8, [r9+120]
	287 Compare r8, rax
	288 JumpIfGreater {290}
	289 Move r8, rax
	290 Nop 
	291 Subtract r10, r10, [r9+124]
	292 Compare r10, r11
	293 JumpIfGreater {295}
	294 Move r10, r11
	295 Nop 
	296 Compare r8, r10
	297 JumpIfLessOrEqual {299}
	298 Move r10, r8
	299 Nop 
	300 Compare r10, 2
	301 JumpIfGreater {320}
	302 Move rax, r11
	303 Neg rax
	304 Compare rax, r11
	305 Move xmm0, r10
	306 Move xmm0, xmm0
	307 JumpIfGreater {309}
	308 Move rax, r11
	309 Nop 
	310 Move xmm1, rax
	311 Move xmm1, xmm1
	312 Multiply xmm1, xmm1, xmm12
	313 Add xmm1, xmm1, xmm0
	314 Compare rsi, 0
	315 JumpIfEqual {318}
	316 Compare xmm11, xmm1
	317 JumpIfLessOrEqual {320}
	318 Move rsi, r9
	319 Move xmm11, xmm1
	320 Move rax, [rbx+24]
	321 Add rdi, rdi, 1
	322 Move rdx, rdi
	323 Compare rax, 0
	324 JumpIfNotEqual {261}
	325 Goto {642}
	326 Compare rsi, 0
	327 JumpIfEqual {448}
	328 Compare [0x184EEB658], r14
	329 Move [rbx+136], 26
	330 Move [rbx+160], 1500
	331 Move rdi, "anim_shooting"
	332 JumpIfNotEqual {338}
	333 LoadAddress rcx, [0x184C92A80]
	334 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	335 LoadAddress rcx, [0x184C911F8]
	336 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	337 Move [0x184EEB658], 1
	338 Compare rdi, 0
	339 JumpIfEqual {642}
	340 Move r8, ""
	341 Move r9, 0
	342 Move rdx, "anim_"
	343 Move rcx, rdi
	344 Call String.Replace, rcx, rdx, r8
	345 Move rcx, [rbx+320]
	346 Move rdi, rax
	347 Compare rcx, 0
	348 JumpIfEqual {642}
	349 Move r9, 0
	350 Move r8, 0
	351 Move xmm1, xmm14
	352 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	353 Move rcx, [rbx+320]
	354 Compare rcx, 0
	355 JumpIfEqual {642}
	356 Move xmm3, [0x183C33DB4]
	357 Move r8, 0
	358 Move stack:0x28, r14
	359 Move rdx, rdi
	360 Move stack:0x20, 3
	361 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	362 Move r8, [rbx+16]
	363 Compare r8, 0
	364 JumpIfEqual {642}
	365 Move r8, [r8+88]
	366 Compare r8, 0
	367 JumpIfEqual {642}
	368 Move rdx, typeof(Reloaded.Services.IAudioService)
	369 Move rcx, 6
	370 Move r9, 42
	371 Call 0x180002040, rcx, rdx, r8, r9
	372 Move rdx, 0
	373 Move rcx, rsi
	374 Call GridItem.GridItemDie, rcx, rdx
	375 Compare [rbx+112], 45
	376 Move r9, [rbx+280]
	377 JumpIfEqual {384}
	378 Compare r9, 0
	379 JumpIfEqual {642}
	380 Compare [r9+24], r14
	381 JumpIfLessOrEqual {640}
	382 Move r14, [r9+32]
	383 Goto {407}
	384 Nop 
	385 LoadAddress rdx, [r9+32]
	386 Move rcx, r14
	387 Move rax, r14
	388 Compare r9, 0
	389 JumpIfEqual {642}
	390 Compare rax, [r9+24]
	391 JumpIfGreaterOrEqual {640}
	392 Move r8, [rdx]
	393 Compare r8, 0
	394 JumpIfEqual {642}
	395 Compare [r8+32], r14
	396 JumpIfEqual {403}
	397 Add rax, rax, 1
	398 Add rcx, rcx, 1
	399 Add rdx, rdx, 8
	400 Compare rcx, 5
	401 JumpIfLess {390}
	402 Goto {407}
	403 Compare r9, 0
	404 JumpIfEqual {642}
	405 Move rax, rax
	406 Move r14, [r9+32+rax*8]
	407 Move rcx, [rbx+24]
	408 Compare rcx, 0
	409 JumpIfEqual {642}
	410 Move r8, [rsi+124]
	411 Move r9, 0
	412 Move rdx, [rsi+120]
	413 Call Board.GridToPixelX, rcx, rdx, r8
	414 Compare r14, 0
	415 JumpIfEqual {642}
	416 Add rax, rax, 40
	417 Move xmm0, rax
	418 Move xmm0, xmm0
	419 Move [r14+16], xmm0
	420 Move rcx, [rbx+24]
	421 Compare rcx, 0
	422 JumpIfEqual {642}
	423 Move r8, [rsi+124]
	424 Move r9, 0
	425 Move rdx, [rsi+120]
	426 Call Board.GridToPixelY, rcx, rdx, r8
	427 Move xmm0, rax
	428 Move xmm0, xmm0
	429 Move [r14+20], xmm0
	430 Move rcx, typeof(Reloaded.Gameplay.Common)
	431 Compare [rcx+228], 0
	432 JumpIfNotEqual {434}
	433 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	434 Move xmm7, [0x183C33DAC]
	435 Move r8, 0
	436 Move xmm6, [0x183C33F38]
	437 Move xmm1, xmm7
	438 Move xmm0, xmm6
	439 Call Common.RandRangeFloat, xmm0, xmm1, r8
	440 Add xmm0, xmm0, xmm7
	441 Move r8, 0
	442 Move xmm1, xmm7
	443 Move [r14+24], xmm0
	444 Move xmm0, xmm6
	445 Call Common.RandRangeFloat, xmm0, xmm1, r8
	446 Move [r14+28], xmm0
	447 Move [r14+32], 17
	448 Move xmm15, stack:0x60
	449 Move xmm13, stack:0x80
	450 Move xmm11, stack:0xA0
	451 Move xmm10, stack:0xB0
	452 Move xmm9, stack:0xC0
	453 Move xmm8, stack:0xD0
	454 Move xmm7, stack:0xE0
	455 Move xmm6, stack:0xF0
	456 Move r15, stack:0x148
	457 Move r13, stack:0x138
	458 Move r12, stack:0x130
	459 Move xmm12, stack:0x90
	460 Move xmm14, stack:0x70
	461 ShiftStack 256
	462 Move r14, stack:0x0
	463 ShiftStack 8
	464 Move rdi, stack:0x0
	465 ShiftStack 8
	466 Move rsi, stack:0x0
	467 ShiftStack 8
	468 Move rbp, stack:0x0
	469 ShiftStack 8
	470 Move rbx, stack:0x0
	471 ShiftStack 8
	472 Return 
	473 Move r8, 0
	474 Move rdx, r13
	475 Move rcx, rbx
	476 Call Plant.MagnetShroomAttactItem, rcx, rdx
	477 Goto {448}
	478 Move rcx, [rbx+320]
	479 Compare rcx, 0
	480 JumpIfEqual {642}
	481 Move r8, 0
	482 Move rdx, 0
	483 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	484 Compare rax, 0
	485 JumpIfLessOrEqual {533}
	486 Compare [0x184EEB658], r14
	487 Move rdi, "anim_nonactive_idle2"
	488 JumpIfNotEqual {494}
	489 LoadAddress rcx, [0x184C92A80]
	490 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	491 LoadAddress rcx, [0x184C911F8]
	492 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	493 Move [0x184EEB658], 1
	494 Compare rdi, 0
	495 JumpIfEqual {642}
	496 Move r8, ""
	497 Move r9, 0
	498 Move rdx, "anim_"
	499 Move rcx, rdi
	500 Call String.Replace, rcx, rdx, r8
	501 Move rcx, [rbx+320]
	502 Move rdi, rax
	503 Compare rcx, 0
	504 JumpIfEqual {642}
	505 Move r9, 0
	506 Move r8, 0
	507 Move xmm1, xmm14
	508 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	509 Move rcx, [rbx+320]
	510 Compare rcx, 0
	511 JumpIfEqual {642}
	512 Move xmm3, typeof(T)
	513 Move r8, 0
	514 Move stack:0x28, r14
	515 Move rdx, rdi
	516 Move stack:0x20, r14
	517 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	518 Move rcx, [rbx+16]
	519 Compare rcx, 0
	520 JumpIfEqual {642}
	521 Move rdx, 0
	522 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	523 Compare rax, 0
	524 JumpIfEqual {532}
	525 Move rcx, [rbx+320]
	526 Compare rcx, 0
	527 JumpIfEqual {642}
	528 Move r9, 0
	529 Move r8, 0
	530 Move xmm1, 0
	531 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	532 Move [rbx+136], 27
	533 Move rdx, 0
	534 Move rcx, rbx
	535 Call Plant.DrawMagnetItems, rcx, rdx
	536 Goto {448}
	537 Compare [rbx+160], r14
	538 JumpIfNotEqual {448}
	539 Move [rbx+136], 1
	540 Move rcx, typeof(Reloaded.Gameplay.Common)
	541 Compare [rcx+228], r14
	542 JumpIfNotEqual {544}
	543 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	544 Move xmm1, [0x183C33DB8]
	545 Move r8, 0
	546 Move xmm0, [0x183C33DAC]
	547 Call Common.RandRangeFloat, xmm0, xmm1, r8
	548 Compare [0x184EEB658], r14
	549 Move xmm6, xmm0
	550 Move rdi, "anim_idle"
	551 JumpIfNotEqual {557}
	552 LoadAddress rcx, [0x184C92A80]
	553 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	554 LoadAddress rcx, [0x184C911F8]
	555 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	556 Move [0x184EEB658], 1
	557 Compare rdi, 0
	558 JumpIfEqual {642}
	559 Move r8, ""
	560 Move r9, 0
	561 Move rdx, "anim_"
	562 Move rcx, rdi
	563 Call String.Replace, rcx, rdx, r8
	564 Move rcx, [rbx+320]
	565 Move rdi, rax
	566 Compare rcx, 0
	567 JumpIfEqual {642}
	568 Move xmm1, [0x183C33C60]
	569 Move r9, 0
	570 Move r8, 0
	571 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	572 Move rcx, [rbx+320]
	573 Compare rcx, 0
	574 JumpIfEqual {642}
	575 Move stack:0x28, r14
	576 Move xmm3, xmm6
	577 Move r8, 0
	578 Move stack:0x20, r14
	579 Move rdx, rdi
	580 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	581 Move rcx, [rbx+16]
	582 Compare rcx, 0
	583 JumpIfEqual {642}
	584 Move rdx, 0
	585 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	586 Compare rax, 0
	587 JumpIfEqual {595}
	588 Move rcx, [rbx+320]
	589 Compare rcx, 0
	590 JumpIfEqual {642}
	591 Move r9, 0
	592 Move r8, 0
	593 Move xmm1, 0
	594 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	595 Move rax, [rbx+280]
	596 Compare rax, 0
	597 JumpIfEqual {642}
	598 Compare [rax+24], r14
	599 JumpIfLessOrEqual {640}
	600 Move rcx, [rax+32]
	601 Compare rcx, 0
	602 JumpIfEqual {642}
	603 Move [rcx+32], r14
	604 Move rax, [rbx+336]
	605 Compare rax, 0
	606 JumpIfEqual {642}
	607 Compare [rax+24], r14
	608 JumpIfLessOrEqual {640}
	609 Move rcx, typeof(UnityEngine.Object)
	610 Move rdi, [rax+32]
	611 Compare [rcx+228], r14
	612 JumpIfNotEqual {614}
	613 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	614 Move r8, 0
	615 Move rdx, 0
	616 Move rcx, rdi
	617 Call Object.op_Inequality, rcx, rdx, r8
	618 Compare rax, 0
	619 JumpIfEqual {448}
	620 Move rax, [rbx+336]
	621 Compare rax, 0
	622 JumpIfEqual {642}
	623 Compare [rax+24], r14
	624 JumpIfLessOrEqual {640}
	625 Move rcx, [rax+32]
	626 Compare rcx, 0
	627 JumpIfEqual {642}
	628 Move rdx, 0
	629 Call MagnetItemController.Die, rcx, rdx
	630 Move rcx, [rbx+336]
	631 Compare rcx, 0
	632 JumpIfEqual {642}
	633 Compare [rcx+24], r14
	634 JumpIfLessOrEqual {640}
	635 Move [rcx+32], r14
	636 Move rdx, 0
	637 Add rcx, rcx, 32
	638 Call 0x1804FDEA0, rcx, rdx, r8, r9
	639 Goto {448}
	640 Call 0x1804FEE10, rcx, rdx, r8, r9
	641 Interrupt 
	642 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
