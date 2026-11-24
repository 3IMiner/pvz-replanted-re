# System.Void DoSpecial()

- 类：`Plant`
- 汇编行数：1193

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rbx
	push rsi
	sub rsp,80h
	cmp byte ptr [184EEB63Ah],0
	mov rbx,rcx
	movaps [rsp+70h],xmm6
	movaps [rsp+60h],xmm7
	jne short 00000001806AD7DAh
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C7ECA0h]
	call 00000001804FEB70h
	lea rcx,[184C93B60h]
	call 00000001804FEB70h
	lea rcx,[184C933C8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB63Ah],1
	movd xmm6,dword ptr [rbx+28h]
	xor r8d,r8d
	movd xmm7,dword ptr [rbx+2Ch]
	xor edx,edx
	cvtdq2ps xmm6,xmm6
	mov rcx,rbx
	mov [rsp+90h],rdi
	cvtdq2ps xmm7,xmm7
	mulss xmm6,dword ptr [183C33C40h]
	mulss xmm7,dword ptr [183C33C40h]
	addss xmm6,dword ptr [rbx+20h]
	addss xmm7,dword ptr [rbx+24h]
	call 00000001806B12F0h
	cmp dword ptr [rbx+70h],1Bh
	mov esi,eax
	je near ptr 00000001806AE0B7h
	cmp dword ptr [rbx+70h],2
	je near ptr 00000001806ADF63h
	cmp dword ptr [rbx+70h],0Fh
	je near ptr 00000001806ADDA7h
	cmp dword ptr [rbx+70h],14h
	je near ptr 00000001806ADC81h
	cmp dword ptr [rbx+70h],25h
	je near ptr 00000001806ADBCBh
	cmp dword ptr [rbx+70h],0Eh
	je near ptr 00000001806ADA5Dh
	cmp dword ptr [rbx+70h],4
	je near ptr 00000001806AD935h
	cmp dword ptr [rbx+70h],23h
	jne near ptr 00000001806AD912h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov r8d,[rbx+34h]
	xor edi,edi
	mov edx,[rbx+74h]
	mov r9d,6
	mov [rsp+20h],rdi
	call 000000018065F2A0h
	test rax,rax
	je short 00000001806AD8A9h
	cmp [rax+136h],dil
	je short 00000001806AD8A9h
	mov dword ptr [rax+124h],64h
	movss xmm0,dword ptr [183C33FACh]
	mov r9d,14h
	mov dword ptr [rbx+88h],2
	mov r8d,3
	mov rdx,[184C93B60h]
	mov rcx,rbx
	mov [rsp+28h],rdi
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,45h
	call 0000000180002040h
	mov rdi,[rsp+90h]
	mov rbx,[rsp+98h]
	movaps xmm6,[rsp+70h]
	movaps xmm7,[rsp+60h]
	add rsp,80h
	pop rsi
	ret
	mov eax,[rbx+28h]
	mov r8,[rbx+10h]
	cdq
	sub eax,edx
	sar eax,1
	movd xmm6,eax
	mov eax,[rbx+2Ch]
	cdq
	sub eax,edx
	sar eax,1
	cvtdq2ps xmm6,xmm6
	movd xmm7,eax
	addss xmm6,dword ptr [rbx+20h]
	cvtdq2ps xmm7,xmm7
	subss xmm6,dword ptr [183C33DBCh]
	addss xmm7,dword ptr [rbx+24h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,75h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+78h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C7ECA0h]
	mov ecx,17h
	mov r9d,2
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov edx,[rbx+34h]
	xor edi,edi
	mov [rsp+40h],rdi
	movaps xmm3,xmm7
	mov [rsp+38h],esi
	movaps xmm2,xmm6
	mov [rsp+30h],dil
	mov [rsp+28h],edi
	mov dword ptr [rsp+20h],3Ch
	call 0000000180664F40h
	cmp eax,1
	jl short 00000001806ADA20h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	xor r9d,r9d
	mov r8b,1
	mov edx,4
	call 00000001807E1800h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov ecx,4AF38h
	call 0000000180665070h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	addss xmm6,dword ptr [183C33DBCh]
	mov [rsp+28h],rdi
	mov r9d,eax
	mov dword ptr [rsp+20h],30h
	jmp near ptr 00000001806AE073h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,12h
	call 0000000180002040h
	cmp byte ptr [184EEB64Ch],0
	jne short 00000001806ADAB6h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Ch],1
	mov rax,[rbx+18h]
	xor edi,edi
	mov esi,edi
	mov edx,edi
	test rax,rax
	je near ptr 00000001806AE1EAh
	nop dword ptr [rax]
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	cmp edx,[rcx+28h]
	jge short 00000001806ADB30h
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov r8,[184C81528h]
	mov edx,esi
	call 0000000182449330h
	test rax,rax
	je near ptr 00000001806AE1EAh
	xor edx,edx
	mov rcx,rax
	call 00000001806F2FF0h
	mov rax,[rbx+18h]
	inc esi
	mov edx,esi
	test rax,rax
	je near ptr 00000001806AE1EAh
	jmp short 00000001806ADAD0h
	mov dword ptr [rax+260h],12Ch
	mov rdx,[rbx+18h]
	test rdx,rdx
	je near ptr 00000001806AE1EAh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov edx,[rdx+268h]
	xor r8d,r8d
	call 00000001807E1000h
	test rax,rax
	je short 00000001806ADB6Eh
	mov byte ptr [rax+92h],1
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	xor edx,edx
	call 000000018065DAD0h
	test rax,rax
	je short 00000001806ADB91h
	xor edx,edx
	mov rcx,rax
	call 00000001806E7130h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov [rsp+28h],rdi
	mov r9d,61A80h
	movaps xmm2,xmm7
	mov dword ptr [rsp+20h],2Ah
	movaps xmm1,xmm6
	call 00000001807D9B50h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	jmp near ptr 00000001806AD912h
	cmp dword ptr [rbx+88h],28h
	je near ptr 00000001806AD912h
	cmp dword ptr [rbx+88h],29h
	je near ptr 00000001806AD912h
	cmp byte ptr [184EEB658h],0
	mov dword ptr [rbx+88h],28h
	mov dword ptr [rbx+0A0h],5
	mov rdi,[184C933C8h]
	jne short 00000001806ADC28h
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806AE1EAh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	movss xmm3,dword ptr [183C33FACh]
	xor edi,edi
	mov [rsp+28h],rdi
	xor r8d,r8d
	mov rdx,rax
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	jmp near ptr 00000001806AD912h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,38h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,41h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+78h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C7ECA0h]
	mov ecx,17h
	mov r9d,2
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov edx,[rbx+34h]
	xor r8d,r8d
	call 000000018065AA20h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	movss xmm3,dword ptr [183C33C4Ch]
	xor edi,edi
	mov edx,3
	mov [rsp+20h],rdi
	mov r8d,0FFFFFFFCh
	call 00000001806709C0h
	mov edx,[rbx+34h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806AC0C0h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov rcx,[rcx+178h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	movsxd rax,dword ptr [rbx+34h]
	cmp eax,[rcx+18h]
	jae near ptr 00000001806AE1F0h
	mov dword ptr [rcx+rax*4+20h],14h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	jmp near ptr 00000001806AD912h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,30h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+78h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C7ECA0h]
	mov ecx,17h
	mov r9d,2
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov edx,[rbx+34h]
	xor edi,edi
	mov [rsp+40h],rdi
	movaps xmm3,xmm7
	mov [rsp+38h],esi
	movaps xmm2,xmm6
	mov byte ptr [rsp+30h],1
	mov dword ptr [rsp+28h],3
	mov dword ptr [rsp+20h],0FAh
	call 0000000180664F40h
	cmp [184EEB651h],dil
	jne short 00000001806ADE6Ch
	lea rcx,[184C7F5F0h]
	call 00000001804FEB70h
	lea rcx,[184C7F6C8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB651h],1
	mov rax,[rbx+18h]
	mov esi,edi
	mov edx,edi
	test rax,rax
	je near ptr 00000001806AE1EAh
	nop dword ptr [rax]
	mov rcx,[rax+78h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	cmp edx,[rcx+28h]
	jge short 00000001806ADEEFh
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov rcx,[rax+78h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov r8,[184C7F6C8h]
	mov edx,esi
	call 0000000182449330h
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov ecx,[rbx+34h]
	cmp [rax+34h],ecx
	jne short 00000001806ADEDDh
	mov ecx,[rax+74h]
	cmp ecx,[rbx+74h]
	jne short 00000001806ADEDDh
	xor edx,edx
	mov rcx,rax
	call 00000001806ACD40h
	mov rax,[rbx+18h]
	inc esi
	mov edx,esi
	test rax,rax
	jne short 00000001806ADE80h
	jmp near ptr 00000001806AE1EAh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov [rsp+28h],rdi
	mov r9d,61A80h
	movaps xmm2,xmm7
	mov dword ptr [rsp+20h],1Eh
	movaps xmm1,xmm6
	call 00000001807D9B50h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 0000000180654C70h
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov dword ptr [rax+80h],4650h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	movss xmm3,dword ptr [183C33D94h]
	jmp near ptr 00000001806AE093h
	mov rax,[rbx+10h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,37h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,41h
	call 0000000180002040h
	mov r8,[rbx+10h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov r8,[r8+78h]
	test r8,r8
	je near ptr 00000001806AE1EAh
	mov rdx,[184C7ECA0h]
	mov ecx,17h
	mov r9d,2
	call 0000000180002040h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov edx,[rbx+34h]
	xor edi,edi
	mov [rsp+40h],rdi
	movaps xmm3,xmm7
	mov [rsp+38h],esi
	movaps xmm2,xmm6
	mov byte ptr [rsp+30h],1
	mov dword ptr [rsp+28h],1
	mov dword ptr [rsp+20h],73h
	call 0000000180664F40h
	cmp eax,0Ah
	jl short 00000001806AE053h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	xor r9d,r9d
	mov r8b,1
	mov edx,5
	call 00000001807E1800h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov [rsp+28h],rdi
	mov r9d,61A80h
	mov dword ptr [rsp+20h],4
	movaps xmm2,xmm7
	movaps xmm1,xmm6
	call 00000001807D9B50h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	movss xmm3,dword ptr [183C33C4Ch]
	mov edx,3
	mov [rsp+20h],rdi
	mov r8d,0FFFFFFFCh
	call 00000001806709C0h
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	jmp near ptr 00000001806AD912h
	cmp dword ptr [rbx+88h],2
	je near ptr 00000001806AD912h
	cmp byte ptr [184EEB64Dh],0
	mov dword ptr [rbx+88h],2
	jne short 00000001806AE102h
	lea rcx,[184C81450h]
	call 00000001804FEB70h
	lea rcx,[184C81528h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	mov byte ptr [184EEB64Dh],1
	mov rax,[rbx+18h]
	xor edi,edi
	mov edx,edi
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	cmp edx,[rcx+28h]
	jge near ptr 00000001806AE1A9h
	mov rax,[rbx+18h]
	test rax,rax
	je near ptr 00000001806AE1EAh
	mov rcx,[rax+70h]
	test rcx,rcx
	je near ptr 00000001806AE1EAh
	mov r8,[184C81528h]
	mov edx,edi
	call 0000000182449330h
	mov rsi,rax
	test rax,rax
	je near ptr 00000001806AE1EAh
	xor edx,edx
	mov rcx,rax
	call 00000001806F3600h
	test al,al
	jne short 00000001806AE196h
	xor r8d,r8d
	lea rcx,[rsp+50h]
	mov rdx,rsi
	call 00000001806F2D70h
	xor edx,edx
	mov rcx,rsi
	call 00000001806F3650h
	test al,al
	je short 00000001806AE196h
	cmp dword ptr [rsi+74h],4Ah
	je short 00000001806AE196h
	mov byte ptr [rsi+111h],1
	mov rax,[rbx+18h]
	inc edi
	mov edx,edi
	test rax,rax
	jne near ptr 00000001806AE113h
	jmp short 00000001806AE1EAh
	mov rax,[rbx+10h]
	test rax,rax
	je short 00000001806AE1EAh
	mov r8,[rax+58h]
	test r8,r8
	je short 00000001806AE1EAh
	mov rdx,[184C75168h]
	mov ecx,19h
	mov r9d,7
	call 0000000180002040h
	mov rax,[rbx+18h]
	test rax,rax
	je short 00000001806AE1EAh
	mov dword ptr [rax+150h],0FA0h
	jmp near ptr 00000001806AD912h
	call 00000001804FEE20h
	int 3
	call 00000001804FEE10h

ISIL:
	001 Move stack:0x10, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rsi
	004 ShiftStack -128
	005 Compare [0x184EEB63A], 0
	006 Move rbx, rcx
	007 Move stack:0x70, xmm6
	008 Move stack:0x60, xmm7
	009 JumpIfNotEqual {19}
	010 LoadAddress rcx, [0x184C75168]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C7ECA0]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 LoadAddress rcx, [0x184C93B60]
	015 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	016 LoadAddress rcx, [0x184C933C8]
	017 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	018 Move [0x184EEB63A], 1
	019 Move xmm6, [rbx+40]
	020 Move r8, 0
	021 Move xmm7, [rbx+44]
	022 Move rdx, 0
	023 Move xmm6, xmm6
	024 Move rcx, rbx
	025 Move stack:0x90, rdi
	026 Move xmm7, xmm7
	027 Multiply xmm6, xmm6, [0x183C33C40]
	028 Multiply xmm7, xmm7, [0x183C33C40]
	029 Add xmm6, xmm6, [rbx+32]
	030 Add xmm7, xmm7, [rbx+36]
	031 Call Plant.GetDamageRangeFlags, rcx, rdx
	032 Compare [rbx+112], 27
	033 Move rsi, rax
	034 JumpIfEqual {528}
	035 Compare [rbx+112], 2
	036 JumpIfEqual {455}
	037 Compare [rbx+112], 15
	038 JumpIfEqual {354}
	039 Compare [rbx+112], 20
	040 JumpIfEqual {291}
	041 Compare [rbx+112], 37
	042 JumpIfEqual {259}
	043 Compare [rbx+112], 14
	044 JumpIfEqual {174}
	045 Compare [rbx+112], 4
	046 JumpIfEqual {90}
	047 Compare [rbx+112], 35
	048 JumpIfNotEqual {82}
	049 Move rcx, [rbx+24]
	050 Compare rcx, 0
	051 JumpIfEqual {600}
	052 Move r8, [rbx+52]
	053 Move rdi, 0
	054 Move rdx, [rbx+116]
	055 Move r9, 6
	056 Move stack:0x20, rdi
	057 Call Board.GetTopPlantAt, rcx, rdx, r8, r9
	058 Compare rax, 0
	059 JumpIfEqual {63}
	060 Compare [rax+310], rdi
	061 JumpIfEqual {63}
	062 Move [rax+292], 100
	063 Move xmm0, [0x183C33FAC]
	064 Move r9, 20
	065 Move [rbx+136], 2
	066 Move r8, 3
	067 Move rdx, "anim_crumble"
	068 Move rcx, rbx
	069 Move stack:0x28, rdi
	070 Move stack:0x20, xmm0
	071 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	072 Move r8, [rbx+16]
	073 Compare r8, 0
	074 JumpIfEqual {600}
	075 Move r8, [r8+88]
	076 Compare r8, 0
	077 JumpIfEqual {600}
	078 Move rdx, typeof(Reloaded.Services.IAudioService)
	079 Move rcx, 6
	080 Move r9, 69
	081 Call 0x180002040, rcx, rdx, r8, r9
	082 Move rdi, stack:0x90
	083 Move rbx, stack:0x98
	084 Move xmm6, stack:0x70
	085 Move xmm7, stack:0x60
	086 ShiftStack 128
	087 Move rsi, stack:0x0
	088 ShiftStack 8
	089 Return 
	090 Move rax, [rbx+40]
	091 Move r8, [rbx+16]
	092 Move TEMP, rax
	093 ShiftRight TEMP, 31
	094 Compare TEMP, 1
	095 JumpIfNotEqual {98}
	096 Move rdx, 0xFFFFFFFF
	097 Goto {99}
	098 Move rdx, 0
	099 Nop 
	100 Subtract rax, rax, rdx
	101 ShiftRight rax, 1
	102 Move xmm6, rax
	103 Move rax, [rbx+44]
	104 Move TEMP, rax
	105 ShiftRight TEMP, 31
	106 Compare TEMP, 1
	107 JumpIfNotEqual {110}
	108 Move rdx, 0xFFFFFFFF
	109 Goto {111}
	110 Move rdx, 0
	111 Nop 
	112 Subtract rax, rax, rdx
	113 ShiftRight rax, 1
	114 Move xmm6, xmm6
	115 Move xmm7, rax
	116 Add xmm6, xmm6, [rbx+32]
	117 Move xmm7, xmm7
	118 Subtract xmm6, xmm6, [0x183C33DBC]
	119 Add xmm7, xmm7, [rbx+36]
	120 Compare r8, 0
	121 JumpIfEqual {600}
	122 Move r8, [r8+88]
	123 Compare r8, 0
	124 JumpIfEqual {600}
	125 Move rdx, typeof(Reloaded.Services.IAudioService)
	126 Move rcx, 25
	127 Move r9, 117
	128 Call 0x180002040, rcx, rdx, r8, r9
	129 Move r8, [rbx+16]
	130 Compare r8, 0
	131 JumpIfEqual {600}
	132 Move r8, [r8+120]
	133 Compare r8, 0
	134 JumpIfEqual {600}
	135 Move rdx, typeof(Reloaded.Input.IInputService)
	136 Move rcx, 23
	137 Move r9, 2
	138 Call 0x180002040, rcx, rdx, r8, r9
	139 Move rcx, [rbx+24]
	140 Compare rcx, 0
	141 JumpIfEqual {600}
	142 Move rdx, [rbx+52]
	143 Move rdi, 0
	144 Move stack:0x40, rdi
	145 Move xmm3, xmm7
	146 Move stack:0x38, rsi
	147 Move xmm2, xmm6
	148 Move stack:0x30, rdi
	149 Move stack:0x28, rdi
	150 Move stack:0x20, 60
	151 Call Board.KillAllZombiesInRadius, rcx, xmm1, xmm2, r9, stack:0x0, stack:0x8, stack:0x10, stack:0x18
	152 Compare rax, 1
	153 JumpIfLess {161}
	154 Move rcx, [rbx+16]
	155 Compare rcx, 0
	156 JumpIfEqual {600}
	157 Move r9, 0
	158 Move r8, 1
	159 Move rdx, 4
	160 Call GameplayActivity.SetAchievement, rcx, rdx, r8
	161 Move rdx, [rbx+52]
	162 Move r9, 0
	163 Move r8, 0
	164 Move rcx, 0x4AF38
	165 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	166 Move rcx, [rbx+16]
	167 Compare rcx, 0
	168 JumpIfEqual {600}
	169 Add xmm6, xmm6, [0x183C33DBC]
	170 Move stack:0x28, rdi
	171 Move r9, rax
	172 Move stack:0x20, 48
	173 Goto {513}
	174 Move rax, [rbx+16]
	175 Compare rax, 0
	176 JumpIfEqual {600}
	177 Move r8, [rax+88]
	178 Compare r8, 0
	179 JumpIfEqual {600}
	180 Move rdx, typeof(Reloaded.Services.IAudioService)
	181 Move rcx, 6
	182 Move r9, 18
	183 Call 0x180002040, rcx, rdx, r8, r9
	184 Compare [0x184EEB64C], 0
	185 JumpIfNotEqual {191}
	186 LoadAddress rcx, [0x184C81450]
	187 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	188 LoadAddress rcx, [0x184C81528]
	189 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	190 Move [0x184EEB64C], 1
	191 Move rax, [rbx+24]
	192 Move rdi, 0
	193 Move rsi, rdi
	194 Move rdx, rdi
	195 Compare rax, 0
	196 JumpIfEqual {600}
	197 Nop 
	198 Move rcx, [rax+112]
	199 Compare rcx, 0
	200 JumpIfEqual {600}
	201 Move rax, [rbx+24]
	202 Compare rax, 0
	203 JumpIfEqual {600}
	204 Compare rdx, [rcx+40]
	205 JumpIfGreaterOrEqual {223}
	206 Move rcx, [rax+112]
	207 Compare rcx, 0
	208 JumpIfEqual {600}
	209 Move r8, [0x184C81528]
	210 Move rdx, rsi
	211 Call 0x182449330, rcx, rdx
	212 Compare rax, 0
	213 JumpIfEqual {600}
	214 Move rdx, 0
	215 Move rcx, rax
	216 Call Zombie.HitIceTrap, rcx, rdx
	217 Move rax, [rbx+24]
	218 Add rsi, rsi, 1
	219 Move rdx, rsi
	220 Compare rax, 0
	221 JumpIfEqual {600}
	222 Goto {198}
	223 Move [rax+608], 300
	224 Move rdx, [rbx+24]
	225 Compare rdx, 0
	226 JumpIfEqual {600}
	227 Move rcx, [rbx+16]
	228 Compare rcx, 0
	229 JumpIfEqual {600}
	230 Move rdx, [rdx+616]
	231 Move r8, 0
	232 Call GameplayActivity.ParticleTryToGet, rcx, rdx
	233 Compare rax, 0
	234 JumpIfEqual {236}
	235 Move [rax+146], 1
	236 Move rcx, [rbx+24]
	237 Compare rcx, 0
	238 JumpIfEqual {600}
	239 Move rdx, 0
	240 Call Board.GetBossZombie, rcx, rdx
	241 Compare rax, 0
	242 JumpIfEqual {246}
	243 Move rdx, 0
	244 Move rcx, rax
	245 Call Zombie.BossDestroyFireball, rcx, rdx
	246 Move rcx, [rbx+16]
	247 Compare rcx, 0
	248 JumpIfEqual {600}
	249 Move stack:0x28, rdi
	250 Move r9, 0x61A80
	251 Move xmm2, xmm7
	252 Move stack:0x20, 42
	253 Move xmm1, xmm6
	254 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	255 Move rdx, 0
	256 Move rcx, rbx
	257 Call Plant.Die, rcx, rdx
	258 Goto {82}
	259 Compare [rbx+136], 40
	260 JumpIfEqual {82}
	261 Compare [rbx+136], 41
	262 JumpIfEqual {82}
	263 Compare [0x184EEB658], 0
	264 Move [rbx+136], 40
	265 Move [rbx+160], 5
	266 Move rdi, "anim_block"
	267 JumpIfNotEqual {273}
	268 LoadAddress rcx, [0x184C92A80]
	269 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	270 LoadAddress rcx, [0x184C911F8]
	271 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	272 Move [0x184EEB658], 1
	273 Compare rdi, 0
	274 JumpIfEqual {600}
	275 Move r8, ""
	276 Move r9, 0
	277 Move rdx, "anim_"
	278 Move rcx, rdi
	279 Call String.Replace, rcx, rdx, r8
	280 Move rcx, [rbx+320]
	281 Compare rcx, 0
	282 JumpIfEqual {600}
	283 Move xmm3, [0x183C33FAC]
	284 Move rdi, 0
	285 Move stack:0x28, rdi
	286 Move r8, 0
	287 Move rdx, rax
	288 Move stack:0x20, 3
	289 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	290 Goto {82}
	291 Move rax, [rbx+16]
	292 Compare rax, 0
	293 JumpIfEqual {600}
	294 Move r8, [rax+88]
	295 Compare r8, 0
	296 JumpIfEqual {600}
	297 Move rdx, typeof(Reloaded.Services.IAudioService)
	298 Move rcx, 6
	299 Move r9, 56
	300 Call 0x180002040, rcx, rdx, r8, r9
	301 Move r8, [rbx+16]
	302 Compare r8, 0
	303 JumpIfEqual {600}
	304 Move r8, [r8+88]
	305 Compare r8, 0
	306 JumpIfEqual {600}
	307 Move rdx, typeof(Reloaded.Services.IAudioService)
	308 Move rcx, 6
	309 Move r9, 65
	310 Call 0x180002040, rcx, rdx, r8, r9
	311 Move r8, [rbx+16]
	312 Compare r8, 0
	313 JumpIfEqual {600}
	314 Move r8, [r8+120]
	315 Compare r8, 0
	316 JumpIfEqual {600}
	317 Move rdx, typeof(Reloaded.Input.IInputService)
	318 Move rcx, 23
	319 Move r9, 2
	320 Call 0x180002040, rcx, rdx, r8, r9
	321 Move rcx, [rbx+24]
	322 Compare rcx, 0
	323 JumpIfEqual {600}
	324 Move rdx, [rbx+52]
	325 Move r8, 0
	326 Call Board.DoFwoosh, rcx, rdx
	327 Move rcx, [rbx+24]
	328 Compare rcx, 0
	329 JumpIfEqual {600}
	330 Move xmm3, [0x183C33C4C]
	331 Move rdi, 0
	332 Move rdx, 3
	333 Move stack:0x20, rdi
	334 Move r8, 0xFFFFFFFC
	335 Call Board.ShakeBoard, rcx, rdx, xmm2, r9
	336 Move rdx, [rbx+52]
	337 Move r8, 0
	338 Move rcx, rbx
	339 Call Plant.BurnRow, rcx, rdx
	340 Move rcx, [rbx+24]
	341 Compare rcx, 0
	342 JumpIfEqual {600}
	343 Move rcx, [rcx+376]
	344 Compare rcx, 0
	345 JumpIfEqual {600}
	346 Move rax, [rbx+52]
	347 Compare rax, [rcx+24]
	348 JumpIfGreaterOrEqual {602}
	349 Move [rcx+32+rax*4], 20
	350 Move rdx, 0
	351 Move rcx, rbx
	352 Call Plant.Die, rcx, rdx
	353 Goto {82}
	354 Move rax, [rbx+16]
	355 Compare rax, 0
	356 JumpIfEqual {600}
	357 Move r8, [rax+88]
	358 Compare r8, 0
	359 JumpIfEqual {600}
	360 Move rdx, typeof(Reloaded.Services.IAudioService)
	361 Move rcx, 25
	362 Move r9, 48
	363 Call 0x180002040, rcx, rdx, r8, r9
	364 Move r8, [rbx+16]
	365 Compare r8, 0
	366 JumpIfEqual {600}
	367 Move r8, [r8+120]
	368 Compare r8, 0
	369 JumpIfEqual {600}
	370 Move rdx, typeof(Reloaded.Input.IInputService)
	371 Move rcx, 23
	372 Move r9, 2
	373 Call 0x180002040, rcx, rdx, r8, r9
	374 Move rcx, [rbx+24]
	375 Compare rcx, 0
	376 JumpIfEqual {600}
	377 Move rdx, [rbx+52]
	378 Move rdi, 0
	379 Move stack:0x40, rdi
	380 Move xmm3, xmm7
	381 Move stack:0x38, rsi
	382 Move xmm2, xmm6
	383 Move stack:0x30, 1
	384 Move stack:0x28, 3
	385 Move stack:0x20, 250
	386 Call Board.KillAllZombiesInRadius, rcx, xmm1, xmm2, r9, stack:0x0, stack:0x8, stack:0x10, stack:0x18
	387 Compare [0x184EEB651], rdi
	388 JumpIfNotEqual {394}
	389 LoadAddress rcx, [0x184C7F5F0]
	390 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	391 LoadAddress rcx, [0x184C7F6C8]
	392 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	393 Move [0x184EEB651], 1
	394 Move rax, [rbx+24]
	395 Move rsi, rdi
	396 Move rdx, rdi
	397 Compare rax, 0
	398 JumpIfEqual {600}
	399 Nop 
	400 Move rcx, [rax+120]
	401 Compare rcx, 0
	402 JumpIfEqual {600}
	403 Compare rdx, [rcx+40]
	404 JumpIfGreaterOrEqual {431}
	405 Move rax, [rbx+24]
	406 Compare rax, 0
	407 JumpIfEqual {600}
	408 Move rcx, [rax+120]
	409 Compare rcx, 0
	410 JumpIfEqual {600}
	411 Move r8, [0x184C7F6C8]
	412 Move rdx, rsi
	413 Call 0x182449330, rcx, rdx
	414 Compare rax, 0
	415 JumpIfEqual {600}
	416 Move rcx, [rbx+52]
	417 Compare [rax+52], rcx
	418 JumpIfNotEqual {425}
	419 Move rcx, [rax+116]
	420 Compare rcx, [rbx+116]
	421 JumpIfNotEqual {425}
	422 Move rdx, 0
	423 Move rcx, rax
	424 Call Plant.Die, rcx, rdx
	425 Move rax, [rbx+24]
	426 Add rsi, rsi, 1
	427 Move rdx, rsi
	428 Compare rax, 0
	429 JumpIfNotEqual {400}
	430 Goto {600}
	431 Move rcx, [rbx+16]
	432 Compare rcx, 0
	433 JumpIfEqual {600}
	434 Move stack:0x28, rdi
	435 Move r9, 0x61A80
	436 Move xmm2, xmm7
	437 Move stack:0x20, 30
	438 Move xmm1, xmm6
	439 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	440 Move rcx, [rbx+24]
	441 Compare rcx, 0
	442 JumpIfEqual {600}
	443 Move r8, [rbx+52]
	444 Move r9, 0
	445 Move rdx, [rbx+116]
	446 Call Board.AddACrater, rcx, rdx, r8
	447 Compare rax, 0
	448 JumpIfEqual {600}
	449 Move [rax+128], 0x4650
	450 Move rcx, [rbx+24]
	451 Compare rcx, 0
	452 JumpIfEqual {600}
	453 Move xmm3, typeof(T)
	454 Goto {520}
	455 Move rax, [rbx+16]
	456 Compare rax, 0
	457 JumpIfEqual {600}
	458 Move r8, [rax+88]
	459 Compare r8, 0
	460 JumpIfEqual {600}
	461 Move rdx, typeof(Reloaded.Services.IAudioService)
	462 Move rcx, 6
	463 Move r9, 55
	464 Call 0x180002040, rcx, rdx, r8, r9
	465 Move r8, [rbx+16]
	466 Compare r8, 0
	467 JumpIfEqual {600}
	468 Move r8, [r8+88]
	469 Compare r8, 0
	470 JumpIfEqual {600}
	471 Move rdx, typeof(Reloaded.Services.IAudioService)
	472 Move rcx, 6
	473 Move r9, 65
	474 Call 0x180002040, rcx, rdx, r8, r9
	475 Move r8, [rbx+16]
	476 Compare r8, 0
	477 JumpIfEqual {600}
	478 Move r8, [r8+120]
	479 Compare r8, 0
	480 JumpIfEqual {600}
	481 Move rdx, typeof(Reloaded.Input.IInputService)
	482 Move rcx, 23
	483 Move r9, 2
	484 Call 0x180002040, rcx, rdx, r8, r9
	485 Move rcx, [rbx+24]
	486 Compare rcx, 0
	487 JumpIfEqual {600}
	488 Move rdx, [rbx+52]
	489 Move rdi, 0
	490 Move stack:0x40, rdi
	491 Move xmm3, xmm7
	492 Move stack:0x38, rsi
	493 Move xmm2, xmm6
	494 Move stack:0x30, 1
	495 Move stack:0x28, 1
	496 Move stack:0x20, 115
	497 Call Board.KillAllZombiesInRadius, rcx, xmm1, xmm2, r9, stack:0x0, stack:0x8, stack:0x10, stack:0x18
	498 Compare rax, 10
	499 JumpIfLess {507}
	500 Move rcx, [rbx+16]
	501 Compare rcx, 0
	502 JumpIfEqual {600}
	503 Move r9, 0
	504 Move r8, 1
	505 Move rdx, 5
	506 Call GameplayActivity.SetAchievement, rcx, rdx, r8
	507 Move rcx, [rbx+16]
	508 Compare rcx, 0
	509 JumpIfEqual {600}
	510 Move stack:0x28, rdi
	511 Move r9, 0x61A80
	512 Move stack:0x20, 4
	513 Move xmm2, xmm7
	514 Move xmm1, xmm6
	515 Call GameplayActivity.AddTodParticle, rcx, xmm1, r8, r9, stack:0x0
	516 Move rcx, [rbx+24]
	517 Compare rcx, 0
	518 JumpIfEqual {600}
	519 Move xmm3, [0x183C33C4C]
	520 Move rdx, 3
	521 Move stack:0x20, rdi
	522 Move r8, 0xFFFFFFFC
	523 Call Board.ShakeBoard, rcx, rdx, xmm2, r9
	524 Move rdx, 0
	525 Move rcx, rbx
	526 Call Plant.Die, rcx, rdx
	527 Goto {82}
	528 Compare [rbx+136], 2
	529 JumpIfEqual {82}
	530 Compare [0x184EEB64D], 0
	531 Move [rbx+136], 2
	532 JumpIfNotEqual {540}
	533 LoadAddress rcx, [0x184C81450]
	534 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	535 LoadAddress rcx, [0x184C81528]
	536 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	537 LoadAddress rcx, [0x184C75168]
	538 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	539 Move [0x184EEB64D], 1
	540 Move rax, [rbx+24]
	541 Move rdi, 0
	542 Move rdx, rdi
	543 Compare rax, 0
	544 JumpIfEqual {600}
	545 Move rcx, [rax+112]
	546 Compare rcx, 0
	547 JumpIfEqual {600}
	548 Compare rdx, [rcx+40]
	549 JumpIfGreaterOrEqual {585}
	550 Move rax, [rbx+24]
	551 Compare rax, 0
	552 JumpIfEqual {600}
	553 Move rcx, [rax+112]
	554 Compare rcx, 0
	555 JumpIfEqual {600}
	556 Move r8, [0x184C81528]
	557 Move rdx, rdi
	558 Call 0x182449330, rcx, rdx
	559 Move rsi, rax
	560 Compare rax, 0
	561 JumpIfEqual {600}
	562 Move rdx, 0
	563 Move rcx, rax
	564 Call Zombie.IsDeadOrDying, rcx, rdx
	565 Compare rax, 0
	566 JumpIfNotEqual {579}
	567 Move r8, 0
	568 LoadAddress rcx, stack:0x50
	569 Move rdx, rsi
	570 Call Zombie.GetZombieRect, rcx, rdx
	571 Move rdx, 0
	572 Move rcx, rsi
	573 Call Zombie.IsFlying, rcx, rdx
	574 Compare rax, 0
	575 JumpIfEqual {579}
	576 Compare [rsi+116], 74
	577 JumpIfEqual {579}
	578 Move [rsi+273], 1
	579 Move rax, [rbx+24]
	580 Add rdi, rdi, 1
	581 Move rdx, rdi
	582 Compare rax, 0
	583 JumpIfNotEqual {545}
	584 Goto {600}
	585 Move rax, [rbx+16]
	586 Compare rax, 0
	587 JumpIfEqual {600}
	588 Move r8, [rax+88]
	589 Compare r8, 0
	590 JumpIfEqual {600}
	591 Move rdx, typeof(Reloaded.Services.IAudioService)
	592 Move rcx, 25
	593 Move r9, 7
	594 Call 0x180002040, rcx, rdx, r8, r9
	595 Move rax, [rbx+24]
	596 Compare rax, 0
	597 JumpIfEqual {600}
	598 Move [rax+336], 4000
	599 Goto {82}
	600 Call 0x1804FEE20, rcx, rdx, r8, r9
	601 Interrupt 
	602 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
