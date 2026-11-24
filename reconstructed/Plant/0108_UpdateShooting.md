# System.Void UpdateShooting()

- 类：`Plant`
- 汇编行数：1233

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,40h
	cmp byte ptr [184EEB660h],0
	mov rbx,rcx
	jne short 00000001806BC7A1h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	lea rcx,[184C688C0h]
	call 00000001804FEB70h
	lea rcx,[184C872F0h]
	call 00000001804FEB70h
	lea rcx,[184C88190h]
	call 00000001804FEB70h
	lea rcx,[184C874A0h]
	call 00000001804FEB70h
	lea rcx,[184C87218h]
	call 00000001804FEB70h
	lea rcx,[184C963E0h]
	call 00000001804FEB70h
	lea rcx,[184C687E8h]
	call 00000001804FEB70h
	lea rcx,[184C873C8h]
	call 00000001804FEB70h
	lea rcx,[184CA7B78h]
	call 00000001804FEB70h
	mov byte ptr [184EEB660h],1
	cmp dword ptr [rbx+70h],11h
	jne short 00000001806BC7CEh
	cmp dword ptr [rbx+88h],5
	je near ptr 00000001806BCDBFh
	cmp dword ptr [rbx+88h],6
	je near ptr 00000001806BCDBFh
	cmp dword ptr [rbx+88h],7
	je near ptr 00000001806BCDBFh
	cmp byte ptr [rbx+3Ch],0
	jne near ptr 00000001806BCDBFh
	cmp dword ptr [rbx+128h],2
	je near ptr 00000001806BCDBFh
	cmp byte ptr [rbx+135h],0
	jne near ptr 00000001806BCDBFh
	cmp dword ptr [rbx+0DCh],0
	je near ptr 00000001806BCDBFh
	mov [rsp+50h],rbp
	mov eax,[rbx+0DCh]
	xor ebp,ebp
	dec eax
	cmp dword ptr [rbx+70h],0Ah
	mov [rbx+0DCh],eax
	jne short 00000001806BC864h
	cmp eax,0Fh
	jne short 00000001806BC864h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov ecx,4AF38h
	call 0000000180665070h
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,eax
	movss xmm1,dword ptr [rbx+20h]
	mov rcx,rbx
	addss xmm2,dword ptr [183C33FC0h]
	addss xmm1,dword ptr [183C33F08h]
	mov [rsp+28h],rbp
	mov dword ptr [rsp+20h],2
	call 00000001806AB220h
	cmp dword ptr [rbx+70h],2Ah
	mov eax,[rbx+0DCh]
	mov [rsp+58h],rsi
	mov [rsp+60h],rdi
	movaps [rsp+30h],xmm6
	je near ptr 00000001806BCB0Ah
	cmp dword ptr [rbx+70h],28h
	je near ptr 00000001806BCADBh
	cmp dword ptr [rbx+70h],2Bh
	je near ptr 00000001806BCAB0h
	cmp eax,1
	jne near ptr 00000001806BCBABh
	cmp dword ptr [rbx+70h],12h
	je near ptr 00000001806BC9FAh
	cmp dword ptr [rbx+70h],1Ch
	je near ptr 00000001806BC97Eh
	cmp dword ptr [rbx+88h],1Eh
	je near ptr 00000001806BC9DCh
	cmp dword ptr [rbx+70h],20h
	je short 00000001806BC8F4h
	cmp dword ptr [rbx+70h],22h
	je short 00000001806BC8F4h
	cmp dword ptr [rbx+70h],27h
	je short 00000001806BC8F4h
	cmp dword ptr [rbx+70h],2Ch
	je short 00000001806BC8F4h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	xor edx,edx
	mov [rsp+20h],rbp
	mov rcx,rbx
	call 00000001806B0580h
	jmp near ptr 00000001806BCDABh
	cmp dword ptr [rbx+88h],27h
	mov edi,ebp
	jne short 00000001806BC951h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	mov rdx,[184C687E8h]
	xor r9d,r9d
	mov r8d,0FFFFFFFFh
	call 00000001807C8DB0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	mov rdx,[184C688C0h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8DB0h
	mov [rbx+88h],ebp
	mov edi,1
	mov edx,[rbx+34h]
	xor r9d,r9d
	mov r8d,edi
	mov rcx,rbx
	call 00000001806B0040h
	mov r8d,[rbx+34h]
	mov r9d,edi
	mov rdx,rax
	mov [rsp+20h],rbp
	mov rcx,rbx
	call 00000001806B0580h
	jmp near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,2
	call 00000001807C76C0h
	cmp eax,3
	jne short 00000001806BC9B6h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	xor edx,edx
	mov [rsp+20h],rbp
	mov rcx,rbx
	call 00000001806B0580h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,3
	call 00000001807C76C0h
	cmp eax,3
	jne near ptr 00000001806BCDABh
	mov r8d,[rbx+34h]
	mov r9d,1
	xor edx,edx
	mov [rsp+20h],rbp
	mov rcx,rbx
	call 00000001806B0580h
	jmp near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	mov esi,[rbx+34h]
	mov edi,esi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,2
	call 00000001807C76C0h
	cmp eax,3
	jne short 00000001806BCA37h
	xor r9d,r9d
	mov [rsp+20h],rbp
	lea r8d,[rdi+1]
	xor edx,edx
	mov rcx,rbx
	call 00000001806B0580h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,3
	call 00000001807C76C0h
	cmp eax,3
	jne short 00000001806BCA6Fh
	mov r8d,[rbx+34h]
	xor r9d,r9d
	xor edx,edx
	mov [rsp+20h],rbp
	mov rcx,rbx
	call 00000001806B0580h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,4
	call 00000001807C76C0h
	cmp eax,3
	jne near ptr 00000001806BCDABh
	xor r9d,r9d
	mov [rsp+20h],rbp
	lea r8d,[rsi-1]
	xor edx,edx
	mov rcx,rbx
	call 00000001806B0580h
	jmp near ptr 00000001806BCDABh
	cmp eax,13h
	jne near ptr 00000001806BCBABh
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B0040h
	test rax,rax
	je near ptr 00000001806BCBABh
	mov rdx,rax
	jmp near ptr 00000001806BCB97h
	cmp eax,12h
	je near ptr 00000001806BCB95h
	cmp dword ptr [rbx+0DCh],23h
	je near ptr 00000001806BCB95h
	cmp dword ptr [rbx+0DCh],33h
	je near ptr 00000001806BCB95h
	cmp dword ptr [rbx+0DCh],44h
	jmp near ptr 00000001806BCB93h
	cmp eax,88h
	je short 00000001806BCB2Ch
	cmp dword ptr [rbx+0DCh],6Ch
	je short 00000001806BCB2Ch
	cmp dword ptr [rbx+0DCh],50h
	je short 00000001806BCB2Ch
	cmp dword ptr [rbx+0DCh],34h
	jne short 00000001806BCB71h
	mov edx,[rbx+34h]
	xor r9d,r9d
	xor r8d,r8d
	mov ecx,4AF38h
	call 0000000180665070h
	movss xmm2,dword ptr [rbx+24h]
	mov r9d,eax
	movss xmm1,dword ptr [rbx+20h]
	mov rcx,rbx
	addss xmm2,dword ptr [183C33DC4h]
	addss xmm1,dword ptr [183C33DC4h]
	mov [rsp+28h],rbp
	mov dword ptr [rsp+20h],3Ch
	call 00000001806AB220h
	cmp dword ptr [rbx+0DCh],7Eh
	je short 00000001806BCB95h
	cmp dword ptr [rbx+0DCh],62h
	je short 00000001806BCB95h
	cmp dword ptr [rbx+0DCh],46h
	je short 00000001806BCB95h
	cmp dword ptr [rbx+0DCh],2Ah
	jne short 00000001806BCBABh
	xor edx,edx
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov rcx,rbx
	mov [rsp+20h],rbp
	call 00000001806B0580h
	cmp [rbx+0DCh],ebp
	jne near ptr 00000001806BCDABh
	cmp dword ptr [rbx+70h],12h
	je near ptr 00000001806BCFD3h
	cmp dword ptr [rbx+70h],1Ch
	je near ptr 00000001806BCE6Fh
	cmp dword ptr [rbx+88h],20h
	je near ptr 00000001806BCDC5h
	cmp [rbx+70h],ebp
	je near ptr 00000001806BCCF5h
	cmp dword ptr [rbx+70h],7
	je near ptr 00000001806BCCF5h
	cmp dword ptr [rbx+70h],28h
	je near ptr 00000001806BCCF5h
	cmp dword ptr [rbx+70h],34h
	je near ptr 00000001806BCCF5h
	cmp dword ptr [rbx+70h],5
	je near ptr 00000001806BCCF5h
	mov rdi,[rbx+140h]
	cmp dword ptr [rbx+70h],2Fh
	je short 00000001806BCC79h
	mov rcx,[184C2D478h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806BCC2Ah
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806BCFF4h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BCFF4h
	movss xmm1,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806B4C50h
	jmp near ptr 00000001806BCDABh
	test rdi,rdi
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BCFF4h
	mov rcx,[rbx+140h]
	mov dword ptr [rbx+88h],23h
	mov dword ptr [rbx+0A0h],0BB8h
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	mov rdx,[184CA7B78h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8230h
	jmp near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,2
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BCFF4h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	movss xmm1,dword ptr [183C33DBCh]
	xor r9d,r9d
	mov r8d,2
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C87218h]
	movaps xmm3,xmm0
	mov r8d,2
	mov [rsp+20h],rbp
	mov rcx,rdi
	call 00000001807C8210h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,2
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8790h
	mov rdi,[rsp+60h]
	mov rsi,[rsp+58h]
	movaps xmm6,[rsp+30h]
	mov rbp,[rsp+50h]
	add rsp,40h
	pop rbx
	ret
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BCFF4h
	mov rdx,[184C963E0h]
	xorps xmm6,xmm6
	mov [rsp+28h],rbp
	mov r9d,14h
	xor r8d,r8d
	movss dword ptr [rsp+20h],xmm6
	mov rcx,rbx
	call 00000001806B4B80h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	movss xmm1,dword ptr [183C33DB4h]
	xor r9d,r9d
	xor r8d,r8d
	call 00000001807C8740h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r9d,r9d
	xor r8d,r8d
	xorps xmm1,xmm1
	call 00000001807C8740h
	jmp near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,2
	call 00000001807C7A30h
	movss xmm6,dword ptr [183C33DBCh]
	test eax,eax
	jle near ptr 00000001806BCF28h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r9d,r9d
	mov r8d,2
	movaps xmm1,xmm6
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C87218h]
	movaps xmm3,xmm0
	mov r8d,2
	mov [rsp+20h],rbp
	mov rcx,rdi
	call 00000001807C8210h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,2
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8790h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,3
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r9d,r9d
	mov r8d,3
	movaps xmm1,xmm6
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C88190h]
	movaps xmm3,xmm0
	mov r8d,3
	mov [rsp+20h],rbp
	mov rcx,rdi
	call 00000001807C8210h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,3
	jmp near ptr 00000001806BCDA0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,3
	call 00000001807C7A30h
	test eax,eax
	jg short 00000001806BD003h
	mov dword ptr [rbx+0DCh],1
	jmp near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,2
	call 00000001807C76C0h
	movss xmm6,dword ptr [183C33DBCh]
	cmp eax,3
	jne near ptr 00000001806BD0BDh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r9d,r9d
	mov r8d,2
	movaps xmm1,xmm6
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C872F0h]
	movaps xmm3,xmm0
	mov r8d,2
	mov [rsp+20h],rbp
	mov rcx,rdi
	call 00000001807C8210h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,2
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8790h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r9d,r9d
	mov r8d,3
	movaps xmm1,xmm6
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C873C8h]
	movaps xmm3,xmm0
	mov r8d,3
	mov [rsp+20h],rbp
	mov rcx,rdi
	call 00000001807C8210h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,3
	movaps xmm1,xmm0
	mov rcx,rdi
	call 00000001807C8790h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BD1E9h
	xor r8d,r8d
	mov edx,4
	call 00000001807C76C0h
	cmp eax,3
	jne near ptr 00000001806BCDABh
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BD1E9h
	xor r9d,r9d
	mov r8d,4
	movaps xmm1,xmm6
	call 000000018060F880h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je short 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78A0h
	mov rdx,[184C874A0h]
	movaps xmm3,xmm0
	mov r8d,4
	mov [rsp+20h],rbp
	mov rcx,rdi
	call 00000001807C8210h
	mov rdi,[rbx+140h]
	mov rcx,rdi
	test rcx,rcx
	je short 00000001806BD1E9h
	xor r8d,r8d
	xor edx,edx
	call 00000001807C78E0h
	xor r9d,r9d
	mov r8d,4
	jmp near ptr 00000001806BCDA0h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -64
	004 Compare [0x184EEB660], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {28}
	007 LoadAddress rcx, [0x184C2D478]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C688C0]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C872F0]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C88190]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C874A0]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C87218]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C963E0]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 LoadAddress rcx, [0x184C687E8]
	022 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	023 LoadAddress rcx, [0x184C873C8]
	024 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	025 LoadAddress rcx, [0x184CA7B78]
	026 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	027 Move [0x184EEB660], 1
	028 Compare [rbx+112], 17
	029 JumpIfNotEqual {36}
	030 Compare [rbx+136], 5
	031 JumpIfEqual {373}
	032 Compare [rbx+136], 6
	033 JumpIfEqual {373}
	034 Compare [rbx+136], 7
	035 JumpIfEqual {373}
	036 Compare [rbx+60], 0
	037 JumpIfNotEqual {373}
	038 Compare [rbx+296], 2
	039 JumpIfEqual {373}
	040 Compare [rbx+309], 0
	041 JumpIfNotEqual {373}
	042 Compare [rbx+220], 0
	043 JumpIfEqual {373}
	044 Move stack:0x50, rbp
	045 Move rax, [rbx+220]
	046 Move rbp, 0
	047 Subtract rax, rax, 1
	048 Compare [rbx+112], 10
	049 Move [rbx+220], rax
	050 JumpIfNotEqual {67}
	051 Compare rax, 15
	052 JumpIfNotEqual {67}
	053 Move rdx, [rbx+52]
	054 Move r9, 0
	055 Move r8, 0
	056 Move rcx, 0x4AF38
	057 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	058 Move xmm2, [rbx+36]
	059 Move r9, rax
	060 Move xmm1, [rbx+32]
	061 Move rcx, rbx
	062 Add xmm2, xmm2, [0x183C33FC0]
	063 Add xmm1, xmm1, [0x183C33F08]
	064 Move stack:0x28, rbp
	065 Move stack:0x20, 2
	066 Call Plant.AddAttachedParticle, rcx, xmm1, r8, r9, stack:0x0
	067 Compare [rbx+112], 42
	068 Move rax, [rbx+220]
	069 Move stack:0x58, rsi
	070 Move stack:0x60, rdi
	071 Move stack:0x30, xmm6
	072 JumpIfEqual {224}
	073 Compare [rbx+112], 40
	074 JumpIfEqual {216}
	075 Compare [rbx+112], 43
	076 JumpIfEqual {205}
	077 Compare rax, 1
	078 JumpIfNotEqual {260}
	079 Compare [rbx+112], 18
	080 JumpIfEqual {160}
	081 Compare [rbx+112], 28
	082 JumpIfEqual {131}
	083 Compare [rbx+136], 30
	084 JumpIfEqual {153}
	085 Compare [rbx+112], 32
	086 JumpIfEqual {100}
	087 Compare [rbx+112], 34
	088 JumpIfEqual {100}
	089 Compare [rbx+112], 39
	090 JumpIfEqual {100}
	091 Compare [rbx+112], 44
	092 JumpIfEqual {100}
	093 Move r8, [rbx+52]
	094 Move r9, 0
	095 Move rdx, 0
	096 Move stack:0x20, rbp
	097 Move rcx, rbx
	098 Call Plant.Fire, rcx, rdx, r8, r9
	099 Goto {369}
	100 Compare [rbx+136], 39
	101 Move rdi, rbp
	102 JumpIfNotEqual {119}
	103 Move rcx, [rbx+320]
	104 Compare rcx, 0
	105 JumpIfEqual {615}
	106 Move rdx, "Cornpult_butter"
	107 Move r9, 0
	108 Move r8, 0xFFFFFFFF
	109 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	110 Move rcx, [rbx+320]
	111 Compare rcx, 0
	112 JumpIfEqual {615}
	113 Move rdx, "Cornpult_kernal"
	114 Move r9, 0
	115 Move r8, 0
	116 Call ReloadedController.AssignRenderGroupToPrefix, rcx, rdx, r8
	117 Move [rbx+136], rbp
	118 Move rdi, 1
	119 Move rdx, [rbx+52]
	120 Move r9, 0
	121 Move r8, rdi
	122 Move rcx, rbx
	123 Call Plant.FindTargetZombie, rcx, rdx, r8
	124 Move r8, [rbx+52]
	125 Move r9, rdi
	126 Move rdx, rax
	127 Move stack:0x20, rbp
	128 Move rcx, rbx
	129 Call Plant.Fire, rcx, rdx, r8, r9
	130 Goto {369}
	131 Move rcx, [rbx+320]
	132 Compare rcx, 0
	133 JumpIfEqual {615}
	134 Move r8, 0
	135 Move rdx, 2
	136 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	137 Compare rax, 3
	138 JumpIfNotEqual {145}
	139 Move r8, [rbx+52]
	140 Move r9, 0
	141 Move rdx, 0
	142 Move stack:0x20, rbp
	143 Move rcx, rbx
	144 Call Plant.Fire, rcx, rdx, r8, r9
	145 Move rcx, [rbx+320]
	146 Compare rcx, 0
	147 JumpIfEqual {615}
	148 Move r8, 0
	149 Move rdx, 3
	150 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	151 Compare rax, 3
	152 JumpIfNotEqual {369}
	153 Move r8, [rbx+52]
	154 Move r9, 1
	155 Move rdx, 0
	156 Move stack:0x20, rbp
	157 Move rcx, rbx
	158 Call Plant.Fire, rcx, rdx, r8, r9
	159 Goto {369}
	160 Move rcx, [rbx+320]
	161 Move rsi, [rbx+52]
	162 Move rdi, rsi
	163 Compare rcx, 0
	164 JumpIfEqual {615}
	165 Move r8, 0
	166 Move rdx, 2
	167 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	168 Compare rax, 3
	169 JumpIfNotEqual {176}
	170 Move r9, 0
	171 Move stack:0x20, rbp
	172 LoadAddress r8, [rdi+1]
	173 Move rdx, 0
	174 Move rcx, rbx
	175 Call Plant.Fire, rcx, rdx, r8, r9
	176 Move rcx, [rbx+320]
	177 Compare rcx, 0
	178 JumpIfEqual {615}
	179 Move r8, 0
	180 Move rdx, 3
	181 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	182 Compare rax, 3
	183 JumpIfNotEqual {190}
	184 Move r8, [rbx+52]
	185 Move r9, 0
	186 Move rdx, 0
	187 Move stack:0x20, rbp
	188 Move rcx, rbx
	189 Call Plant.Fire, rcx, rdx, r8, r9
	190 Move rcx, [rbx+320]
	191 Compare rcx, 0
	192 JumpIfEqual {615}
	193 Move r8, 0
	194 Move rdx, 4
	195 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	196 Compare rax, 3
	197 JumpIfNotEqual {369}
	198 Move r9, 0
	199 Move stack:0x20, rbp
	200 LoadAddress r8, [rsi-1]
	201 Move rdx, 0
	202 Move rcx, rbx
	203 Call Plant.Fire, rcx, rdx, r8, r9
	204 Goto {369}
	205 Compare rax, 19
	206 JumpIfNotEqual {260}
	207 Move rdx, [rbx+52]
	208 Move r9, 0
	209 Move r8, 0
	210 Move rcx, rbx
	211 Call Plant.FindTargetZombie, rcx, rdx, r8
	212 Compare rax, 0
	213 JumpIfEqual {260}
	214 Move rdx, rax
	215 Goto {255}
	216 Compare rax, 18
	217 JumpIfEqual {254}
	218 Compare [rbx+220], 35
	219 JumpIfEqual {254}
	220 Compare [rbx+220], 51
	221 JumpIfEqual {254}
	222 Compare [rbx+220], 68
	223 Goto {253}
	224 Compare rax, 136
	225 JumpIfEqual {232}
	226 Compare [rbx+220], 108
	227 JumpIfEqual {232}
	228 Compare [rbx+220], 80
	229 JumpIfEqual {232}
	230 Compare [rbx+220], 52
	231 JumpIfNotEqual {246}
	232 Move rdx, [rbx+52]
	233 Move r9, 0
	234 Move r8, 0
	235 Move rcx, 0x4AF38
	236 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	237 Move xmm2, [rbx+36]
	238 Move r9, rax
	239 Move xmm1, [rbx+32]
	240 Move rcx, rbx
	241 Add xmm2, xmm2, [0x183C33DC4]
	242 Add xmm1, xmm1, [0x183C33DC4]
	243 Move stack:0x28, rbp
	244 Move stack:0x20, 60
	245 Call Plant.AddAttachedParticle, rcx, xmm1, r8, r9, stack:0x0
	246 Compare [rbx+220], 126
	247 JumpIfEqual {254}
	248 Compare [rbx+220], 98
	249 JumpIfEqual {254}
	250 Compare [rbx+220], 70
	251 JumpIfEqual {254}
	252 Compare [rbx+220], 42
	253 JumpIfNotEqual {260}
	254 Move rdx, 0
	255 Move r8, [rbx+52]
	256 Move r9, 0
	257 Move rcx, rbx
	258 Move stack:0x20, rbp
	259 Call Plant.Fire, rcx, rdx, r8, r9
	260 Compare [rbx+220], rbp
	261 JumpIfNotEqual {369}
	262 Compare [rbx+112], 18
	263 JumpIfEqual {494}
	264 Compare [rbx+112], 28
	265 JumpIfEqual {415}
	266 Compare [rbx+136], 32
	267 JumpIfEqual {377}
	268 Compare [rbx+112], rbp
	269 JumpIfEqual {329}
	270 Compare [rbx+112], 7
	271 JumpIfEqual {329}
	272 Compare [rbx+112], 40
	273 JumpIfEqual {329}
	274 Compare [rbx+112], 52
	275 JumpIfEqual {329}
	276 Compare [rbx+112], 5
	277 JumpIfEqual {329}
	278 Move rdi, [rbx+320]
	279 Compare [rbx+112], 47
	280 JumpIfEqual {304}
	281 Move rcx, typeof(UnityEngine.Object)
	282 Compare [rcx+228], rbp
	283 JumpIfNotEqual {285}
	284 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	285 Move r8, 0
	286 Move rdx, 0
	287 Move rcx, rdi
	288 Call Object.op_Inequality, rcx, rdx, r8
	289 Compare rax, 0
	290 JumpIfEqual {502}
	291 Move rcx, [rbx+320]
	292 Compare rcx, 0
	293 JumpIfEqual {615}
	294 Move r8, 0
	295 Move rdx, 0
	296 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	297 Compare rax, 0
	298 JumpIfLessOrEqual {502}
	299 Move xmm1, [0x183C33DB4]
	300 Move r8, 0
	301 Move rcx, rbx
	302 Call Plant.PlayIdleAnim, rcx, rdx
	303 Goto {369}
	304 Compare rdi, 0
	305 JumpIfEqual {615}
	306 Move r8, 0
	307 Move rdx, 0
	308 Move rcx, rdi
	309 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	310 Compare rax, 0
	311 JumpIfLessOrEqual {502}
	312 Move rcx, [rbx+320]
	313 Move [rbx+136], 35
	314 Move [rbx+160], 3000
	315 Compare rcx, 0
	316 JumpIfEqual {615}
	317 Move xmm1, [0x183C33DBC]
	318 Move r9, 0
	319 Move r8, 0
	320 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	321 Move rcx, [rbx+320]
	322 Compare rcx, 0
	323 JumpIfEqual {615}
	324 Move rdx, "unarmed_idle"
	325 Move r9, 0
	326 Move r8, 0
	327 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, r8
	328 Goto {369}
	329 Move rcx, [rbx+320]
	330 Compare rcx, 0
	331 JumpIfEqual {615}
	332 Move r8, 0
	333 Move rdx, 2
	334 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	335 Compare rax, 0
	336 JumpIfLessOrEqual {502}
	337 Move rcx, [rbx+320]
	338 Compare rcx, 0
	339 JumpIfEqual {615}
	340 Move xmm1, [0x183C33DBC]
	341 Move r9, 0
	342 Move r8, 2
	343 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	344 Move rdi, [rbx+320]
	345 Move rcx, rdi
	346 Compare rcx, 0
	347 JumpIfEqual {615}
	348 Move r8, 0
	349 Move rdx, 0
	350 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	351 Move rdx, "head_idle"
	352 Move xmm3, xmm0
	353 Move r8, 2
	354 Move stack:0x20, rbp
	355 Move rcx, rdi
	356 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	357 Move rdi, [rbx+320]
	358 Move rcx, rdi
	359 Compare rcx, 0
	360 JumpIfEqual {615}
	361 Move r8, 0
	362 Move rdx, 0
	363 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	364 Move r9, 0
	365 Move r8, 2
	366 Move xmm1, xmm0
	367 Move rcx, rdi
	368 Call ReloadedCharacterController.SetAnimationTimeOnTrack, rcx, rdx, r8
	369 Move rdi, stack:0x60
	370 Move rsi, stack:0x58
	371 Move xmm6, stack:0x30
	372 Move rbp, stack:0x50
	373 ShiftStack 64
	374 Move rbx, stack:0x0
	375 ShiftStack 8
	376 Return 
	377 Move rcx, [rbx+320]
	378 Compare rcx, 0
	379 JumpIfEqual {615}
	380 Move r8, 0
	381 Move rdx, 0
	382 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	383 Compare rax, 0
	384 JumpIfLessOrEqual {502}
	385 Move rdx, "anim_idlehigh"
	386 Move xmm6, 0
	387 Move stack:0x28, rbp
	388 Move r9, 20
	389 Move r8, 0
	390 Move stack:0x20, xmm6
	391 Move rcx, rbx
	392 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	393 Move rcx, [rbx+320]
	394 Compare rcx, 0
	395 JumpIfEqual {615}
	396 Move xmm1, [0x183C33DB4]
	397 Move r9, 0
	398 Move r8, 0
	399 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	400 Move rcx, [rbx+16]
	401 Compare rcx, 0
	402 JumpIfEqual {615}
	403 Move rdx, 0
	404 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	405 Compare rax, 0
	406 JumpIfEqual {369}
	407 Move rcx, [rbx+320]
	408 Compare rcx, 0
	409 JumpIfEqual {615}
	410 Move r9, 0
	411 Move r8, 0
	412 Move xmm1, 0
	413 Call ReloadedCharacterController.SetAnimationRateOnTrack, rcx, rdx, r8
	414 Goto {369}
	415 Move rcx, [rbx+320]
	416 Compare rcx, 0
	417 JumpIfEqual {615}
	418 Move r8, 0
	419 Move rdx, 2
	420 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	421 Move xmm6, [0x183C33DBC]
	422 Compare rax, 0
	423 JumpIfLessOrEqual {456}
	424 Move rcx, [rbx+320]
	425 Compare rcx, 0
	426 JumpIfEqual {615}
	427 Move r9, 0
	428 Move r8, 2
	429 Move xmm1, xmm6
	430 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	431 Move rdi, [rbx+320]
	432 Move rcx, rdi
	433 Compare rcx, 0
	434 JumpIfEqual {615}
	435 Move r8, 0
	436 Move rdx, 0
	437 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	438 Move rdx, "head_idle"
	439 Move xmm3, xmm0
	440 Move r8, 2
	441 Move stack:0x20, rbp
	442 Move rcx, rdi
	443 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	444 Move rdi, [rbx+320]
	445 Move rcx, rdi
	446 Compare rcx, 0
	447 JumpIfEqual {615}
	448 Move r8, 0
	449 Move rdx, 0
	450 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	451 Move r9, 0
	452 Move r8, 2
	453 Move xmm1, xmm0
	454 Move rcx, rdi
	455 Call ReloadedCharacterController.SetAnimationTimeOnTrack, rcx, rdx, r8
	456 Move rcx, [rbx+320]
	457 Compare rcx, 0
	458 JumpIfEqual {615}
	459 Move r8, 0
	460 Move rdx, 3
	461 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	462 Compare rax, 0
	463 JumpIfLessOrEqual {369}
	464 Move rcx, [rbx+320]
	465 Compare rcx, 0
	466 JumpIfEqual {615}
	467 Move r9, 0
	468 Move r8, 3
	469 Move xmm1, xmm6
	470 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	471 Move rdi, [rbx+320]
	472 Move rcx, rdi
	473 Compare rcx, 0
	474 JumpIfEqual {615}
	475 Move r8, 0
	476 Move rdx, 0
	477 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	478 Move rdx, "splitpea_idle"
	479 Move xmm3, xmm0
	480 Move r8, 3
	481 Move stack:0x20, rbp
	482 Move rcx, rdi
	483 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	484 Move rdi, [rbx+320]
	485 Move rcx, rdi
	486 Compare rcx, 0
	487 JumpIfEqual {615}
	488 Move r8, 0
	489 Move rdx, 0
	490 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	491 Move r9, 0
	492 Move r8, 3
	493 Goto {366}
	494 Move rcx, [rbx+320]
	495 Compare rcx, 0
	496 JumpIfEqual {615}
	497 Move r8, 0
	498 Move rdx, 3
	499 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	500 Compare rax, 0
	501 JumpIfGreater {504}
	502 Move [rbx+220], 1
	503 Goto {369}
	504 Move rcx, [rbx+320]
	505 Compare rcx, 0
	506 JumpIfEqual {615}
	507 Move r8, 0
	508 Move rdx, 2
	509 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	510 Move xmm6, [0x183C33DBC]
	511 Compare rax, 3
	512 JumpIfNotEqual {545}
	513 Move rcx, [rbx+320]
	514 Compare rcx, 0
	515 JumpIfEqual {615}
	516 Move r9, 0
	517 Move r8, 2
	518 Move xmm1, xmm6
	519 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	520 Move rdi, [rbx+320]
	521 Move rcx, rdi
	522 Compare rcx, 0
	523 JumpIfEqual {615}
	524 Move r8, 0
	525 Move rdx, 0
	526 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	527 Move rdx, "head_idle1"
	528 Move xmm3, xmm0
	529 Move r8, 2
	530 Move stack:0x20, rbp
	531 Move rcx, rdi
	532 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	533 Move rdi, [rbx+320]
	534 Move rcx, rdi
	535 Compare rcx, 0
	536 JumpIfEqual {615}
	537 Move r8, 0
	538 Move rdx, 0
	539 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	540 Move r9, 0
	541 Move r8, 2
	542 Move xmm1, xmm0
	543 Move rcx, rdi
	544 Call ReloadedCharacterController.SetAnimationTimeOnTrack, rcx, rdx, r8
	545 Move rcx, [rbx+320]
	546 Compare rcx, 0
	547 JumpIfEqual {615}
	548 Move r9, 0
	549 Move r8, 3
	550 Move xmm1, xmm6
	551 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	552 Move rdi, [rbx+320]
	553 Move rcx, rdi
	554 Compare rcx, 0
	555 JumpIfEqual {615}
	556 Move r8, 0
	557 Move rdx, 0
	558 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	559 Move rdx, "head_idle2"
	560 Move xmm3, xmm0
	561 Move r8, 3
	562 Move stack:0x20, rbp
	563 Move rcx, rdi
	564 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	565 Move rdi, [rbx+320]
	566 Move rcx, rdi
	567 Compare rcx, 0
	568 JumpIfEqual {615}
	569 Move r8, 0
	570 Move rdx, 0
	571 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	572 Move r9, 0
	573 Move r8, 3
	574 Move xmm1, xmm0
	575 Move rcx, rdi
	576 Call ReloadedCharacterController.SetAnimationTimeOnTrack, rcx, rdx, r8
	577 Move rcx, [rbx+320]
	578 Compare rcx, 0
	579 JumpIfEqual {615}
	580 Move r8, 0
	581 Move rdx, 4
	582 Call ReloadedCharacterController.GetAnimLoopType, rcx, rdx
	583 Compare rax, 3
	584 JumpIfNotEqual {369}
	585 Move rcx, [rbx+320]
	586 Compare rcx, 0
	587 JumpIfEqual {615}
	588 Move r9, 0
	589 Move r8, 4
	590 Move xmm1, xmm6
	591 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	592 Move rdi, [rbx+320]
	593 Move rcx, rdi
	594 Compare rcx, 0
	595 JumpIfEqual {615}
	596 Move r8, 0
	597 Move rdx, 0
	598 Call ReloadedCharacterController.GetAnimationRateOnTrack, rcx, rdx
	599 Move rdx, "head_idle3"
	600 Move xmm3, xmm0
	601 Move r8, 4
	602 Move stack:0x20, rbp
	603 Move rcx, rdi
	604 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9
	605 Move rdi, [rbx+320]
	606 Move rcx, rdi
	607 Compare rcx, 0
	608 JumpIfEqual {615}
	609 Move r8, 0
	610 Move rdx, 0
	611 Call ReloadedCharacterController.GetAnimationTimeOnTrack, rcx, rdx
	612 Move r9, 0
	613 Move r8, 4
	614 Goto {366}
	615 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
